using DAL;
using Entity;
using Entity.Dto;
using System.Collections.Concurrent;
using System.Text.RegularExpressions;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace BLL
{
    public class TelegramBotService
    {
        private readonly string _token = "7209666668:AAEU-LgqABrHCQuVc7Vl5QZ_EQtpKcVqZXQ";
        private ITelegramBotClient _botClient;
        private CancellationTokenSource _cts;

        private readonly ClienteService _clienteService = new();
        private readonly ReservaService _reservaService = new();
        private readonly PaqueteDeServicioService _paqueteService = new();
        private readonly EventoService _eventoService = new();

        private readonly ConcurrentDictionary<long, Cliente> clientesIdentificados = new();
        private readonly ConcurrentDictionary<long, string> estados = new();
        private readonly ConcurrentDictionary<long, Reserva> reservasEnProceso = new();
        private readonly ConcurrentDictionary<long, Cliente> clientesEnRegistro = new();

        public void Iniciar()
        {
            _botClient = new TelegramBotClient(_token);
            _cts = new CancellationTokenSource();

            var receiverOptions = new ReceiverOptions
            {
                AllowedUpdates = Array.Empty<UpdateType>()
            };

            _botClient.StartReceiving(
                HandleUpdateAsync,
                HandleErrorAsync,
                receiverOptions,
                cancellationToken: _cts.Token
            );

            Console.WriteLine("✅ Bot iniciado...");
        }

        public void Detener()
        {
            _cts?.Cancel();
            Console.WriteLine("🛑 Bot detenido.");
        }

        private async Task HandleUpdateAsync(ITelegramBotClient bot, Update update, CancellationToken ct)
        {
            if (update.Message is not { Type: MessageType.Text, Text: not null } msg)
                return;

            var chatId = msg.Chat.Id;
            var text = msg.Text.Trim();

            if (text.Equals("/start", StringComparison.OrdinalIgnoreCase))
            {
                estados[chatId] = "esperando_telefono";

                await bot.SendMessage(chatId,
                    "👋 ¡Bienvenido a *Orama Studio*! 📸\n\n" +
                    "Aquí podrás registrar tus reservas de forma fácil y rápida.\n\n" +
                    "📞 Por favor, ingresa tu *número de teléfono* (10 dígitos) para verificar si estás registrado.",
                    parseMode: ParseMode.Markdown,
                    cancellationToken: ct);

                return;
            }

            if (!estados.TryGetValue(chatId, out var estado)) return;

            try
            {
                switch (estado)
                {
                    case "esperando_telefono":
                        if (!Regex.IsMatch(text, @"^\d{10}$"))
                        {
                            await bot.SendMessage(chatId, "❗ El número de teléfono debe contener exactamente 10 dígitos. Inténtalo de nuevo.", cancellationToken: ct);
                            return;
                        }

                        var cliente = _clienteService.ObtenerClientePorTelefono(text);
                        if (cliente != null)
                        {
                            clientesIdentificados[chatId] = new Cliente
                            {
                                Id = cliente.Id,
                                Nombre = cliente.Nombre,
                                Apellido = cliente.Apellido,
                                Telefono = cliente.Telefono,
                                Direccion = cliente.Direccion,
                                Email = cliente.Email
                            };

                            estados[chatId] = "menu_principal";
                            await bot.SendMessage(chatId, $"👋 Hola {cliente.Nombre}, ¿qué deseas hacer?\n1️⃣ Crear reserva\n2️⃣ Consultar mis reservas", cancellationToken: ct);
                        }

                        else
                        {
                            clientesEnRegistro[chatId] = new Cliente { Telefono = text };
                            estados[chatId] = "registrando_nombre";
                            await bot.SendMessage(chatId, "📝 ¿Cuál es tu *nombre*? (Solo letras)", parseMode: ParseMode.Markdown, cancellationToken: ct);
                        }
                        return;

                    case "registrando_nombre":
                        if (!Regex.IsMatch(text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ ]+$"))
                        {
                            await bot.SendMessage(chatId, "❗ El nombre solo debe contener letras. Inténtalo de nuevo.", cancellationToken: ct);
                            return;
                        }

                        clientesEnRegistro[chatId].Nombre = text;
                        estados[chatId] = "registrando_apellido";
                        await bot.SendMessage(chatId, "📝 ¿Cuál es tu *apellido*? (Solo letras)", parseMode: ParseMode.Markdown, cancellationToken: ct);
                        return;

                    case "registrando_apellido":
                        if (!Regex.IsMatch(text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ ]+$"))
                        {
                            await bot.SendMessage(chatId, "❗ El apellido solo debe contener letras. Inténtalo de nuevo.", cancellationToken: ct);
                            return;
                        }

                        clientesEnRegistro[chatId].Apellido = text;
                        estados[chatId] = "registrando_direccion";
                        await bot.SendMessage(chatId, "📍 ¿Cuál es tu dirección?", cancellationToken: ct);
                        return;

                    case "registrando_direccion":
                        if (text.Length < 5)
                        {
                            await bot.SendMessage(chatId, "❗ La dirección es muy corta. Inténtalo de nuevo.", cancellationToken: ct);
                            return;
                        }

                        clientesEnRegistro[chatId].Direccion = text;
                        estados[chatId] = "registrando_email";
                        await bot.SendMessage(chatId, "📧 ¿Cuál es tu email?", cancellationToken: ct);
                        return;

                    case "registrando_email":
                        if (!Regex.IsMatch(text, @"^[\w.-]+@[\w-]+\.[a-zA-Z]{2,}$"))
                        {
                            await bot.SendMessage(chatId, "❗ El email no tiene un formato válido. Inténtalo de nuevo.", cancellationToken: ct);
                            return;
                        }

                        clientesEnRegistro[chatId].Email = text;
                        var nuevo = clientesEnRegistro[chatId];
                        _clienteService.Agregar(nuevo);
                        clientesIdentificados[chatId] = nuevo;
                        estados[chatId] = "menu_principal";
                        clientesEnRegistro.TryRemove(chatId, out _);

                        await bot.SendMessage(chatId, $"✅ Registro completado. Hola {nuevo.Nombre}, ¿qué deseas hacer?\n1️⃣ Crear reserva\n2️⃣ Consultar mis reservas", cancellationToken: ct);
                        return;

                    case "menu_principal":
                        if (text == "1")
                        {
                            estados[chatId] = "esperando_fecha_reserva";
                            reservasEnProceso[chatId] = new Reserva
                            {
                                Cliente = clientesIdentificados[chatId],
                                FechaReserva = DateTime.Now,
                                EstadoReserva = "Pendiente",
                                Observaciones = "Reserva desde Telegram"
                            };
                            await bot.SendMessage(chatId, "📅 Ingresa la *fecha y hora* del evento (ej: 2025-06-10 15:30):", parseMode: ParseMode.Markdown, cancellationToken: ct);
                        }
                        else if (text == "2")
                        {
                            var clienteId = clientesIdentificados[chatId].Id;
                            var reservas = _clienteService.ObtenerReservasPorCliente(clienteId)?.ToList() ?? new List<Reserva>();
                            if (reservas.Count == 0)
                            {
                                await bot.SendMessage(chatId, "📭 No tienes reservas registradas.", cancellationToken: ct);
                            }
                            else
                            {
                                var resumen = "📋 *Tus reservas:*\n\n" + string.Join("\n", reservas.Select(r =>
                                    $"- 📅 {r.FechaEvento:yyyy-MM-dd HH:mm} | 📦 Paquete: {r.PaqueteDeServicio?.Nombre ?? "N/A"} | 📌 Estado: {r.EstadoReserva}"));
                                await bot.SendMessage(chatId, resumen, parseMode: ParseMode.Markdown, cancellationToken: ct);
                            }
                        }
                        else
                        {
                            await bot.SendMessage(chatId, "❗ Opción no válida. Escribe 1 para crear reserva o 2 para consultar reservas.", cancellationToken: ct);
                        }
                        return;

                    case "esperando_fecha_reserva":
                        if (!DateTime.TryParse(text, out var fecha) || fecha <= DateTime.Now)
                        {
                            await bot.SendMessage(chatId, "❌ Fecha inválida o pasada. Usa el formato `2025-06-10 15:30` y asegúrate que sea futura.", parseMode: ParseMode.Markdown, cancellationToken: ct);
                            return;
                        }

                        var reserva = reservasEnProceso[chatId];
                        reserva.FechaEvento = fecha;

                        var paquete = _paqueteService.GetAllDTO().FirstOrDefault();
                        if (paquete == null)
                        {
                            await bot.SendMessage(chatId, "❗ No hay paquetes disponibles. Contacta al administrador.", cancellationToken: ct);
                            return;
                        }

                        reserva.PaqueteDeServicio = paquete;

                        // Guardar reserva y obtener el ID
                        int reservaId = _reservaService.Agregar(reserva);
                        reserva.Id = reservaId;

                        // Crear y guardar el evento asociado a la reserva
                        var evento = new Evento
                        {
                            Tipo = paquete.Nombre,
                            Fecha = reserva.FechaEvento,
                            Ubicacion = "Por definir", 
                            Reserva = reserva,
                            Bebe = null 
                        };

                        _eventoService.Agregar(evento);

                        await bot.SendMessage(chatId,
                            $"✅ *Reserva registrada con éxito:*\n📅 {fecha:yyyy-MM-dd HH:mm}\n📦 Paquete: {paquete.Nombre}",
                            parseMode: ParseMode.Markdown, cancellationToken: ct);

                        await bot.SendMessage(chatId,
                            "📞 Uno de nuestros asesores te llamará para confirmar el evento y coordinar el abono del *50%* del paquete.",
                            parseMode: ParseMode.Markdown, cancellationToken: ct);

                        estados[chatId] = "menu_principal";
                        reservasEnProceso.TryRemove(chatId, out _);
                        return;

                }
            }
            catch (Exception ex)
            {
                await bot.SendMessage(chatId, $"❗ Error inesperado: {ex.Message}", cancellationToken: ct);
            }
        }

        private Task HandleErrorAsync(ITelegramBotClient bot, Exception exception, CancellationToken ct)
        {
            Console.WriteLine($"❗ Error en el bot: {exception.GetType().Name} - {exception.Message}");
            return Task.CompletedTask;
        }
    }
}