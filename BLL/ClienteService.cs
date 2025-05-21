using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClienteService
    {
        private readonly CLienteRepository _clienteRepository;

        public ClienteService()
        {
            _clienteRepository = new CLienteRepository();
        }

        public string Agregar(Cliente cliente)
        {
            try
            {
                if (cliente == null)
                    throw new BLLException("El cliente no puede ser nulo.");

                if (string.IsNullOrWhiteSpace(cliente.Nombre))
                    throw new BLLException("El nombre del cliente es obligatorio.");

                if (string.IsNullOrWhiteSpace(cliente.Telefono))
                    throw new BLLException("El teléfono del cliente es obligatorio.");

                if (!string.IsNullOrWhiteSpace(cliente.Email) && !cliente.Email.Contains("@"))
                    throw new BLLException("El email del cliente no es válido.");

                return _clienteRepository.Agregar(cliente);
            }
            catch (Exception ex)
            {
                throw new BLLException("Error en la lógica de negocio al agregar cliente", ex);
            }
        }

        public string Actualizar(Cliente cliente)
        {
            try
            {
                if (cliente == null)
                    throw new BLLException("El cliente no puede ser nulo.");

                if (cliente.Id <= 0)
                    throw new BLLException("ID de cliente inválido.");

                if (string.IsNullOrWhiteSpace(cliente.Nombre))
                    throw new BLLException("El nombre del cliente es obligatorio.");

                if (string.IsNullOrWhiteSpace(cliente.Telefono))
                    throw new BLLException("El teléfono del cliente es obligatorio.");

                if (!string.IsNullOrWhiteSpace(cliente.Email) && !cliente.Email.Contains("@"))
                    throw new BLLException("El email del cliente no es válido.");

                return _clienteRepository.Update(cliente);
            }
            catch (Exception ex)
            {
                throw new BLLException("Error en la lógica de negocio al actualizar cliente", ex);
            }
        }

        public string Eliminar(int id)
        {
            try
            {
                if (id <= 0)
                    throw new BLLException("ID de cliente inválido.");

                return _clienteRepository.Delete(id);
            }
            catch (Exception ex)
            {
                throw new BLLException("Error en la lógica de negocio al eliminar cliente", ex);
            }
        }

        public List<Cliente> ObtenerTodos()
        {
            try
            {
                return _clienteRepository.GetAll();
            }
            catch (Exception ex)
            {
                throw new BLLException("Error en la lógica de negocio al obtener todos los clientes", ex);
            }
        }

        public Cliente ObtenerPorId(int id)
        {
            try
            {
                if (id <= 0)
                    throw new BLLException("ID de cliente inválido.");

                return _clienteRepository.GetById(id);
            }
            catch (Exception ex)
            {
                throw new BLLException("Error en la lógica de negocio al obtener cliente por ID", ex);
            }
        }

        public List<Reserva> ObtenerReservasPorCliente(int idCliente)
        {
            try
            {
                if (idCliente <= 0)
                    throw new BLLException("ID de cliente inválido.");

                return _clienteRepository.ObtenerReservas(idCliente);
            }
            catch (Exception ex)
            {
                throw new BLLException("Error al obtener reservas del cliente", ex);
            }
        }

        public List<Despacho> ObtenerDespachosPorCliente(int idCliente)
        {
            try
            {
                if (idCliente <= 0)
                    throw new BLLException("ID de cliente inválido.");

                return _clienteRepository.ObtenerDespachos(idCliente);
            }
            catch (Exception ex)
            {
                throw new BLLException("Error al obtener despachos del cliente", ex);
            }
        }

        public List<Reserva> ObtenerPagosPorCliente(int idCliente)
        {
            try
            {
                if (idCliente <= 0)
                    throw new BLLException("ID de cliente inválido.");

                return _clienteRepository.ObtenerPagos(idCliente);
            }
            catch (Exception ex)
            {
                throw new BLLException("Error al obtener pagos del cliente", ex);
            }
        }
        public string EnviarMensajeWhatsApp(string numeroTelefono, string mensaje)
        {
            numeroTelefono = "57" + numeroTelefono;
            string mensajeCodificado = WebUtility.UrlEncode(mensaje);
            string url = $"https://wa.me/{numeroTelefono}?text={mensajeCodificado}";

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
                return "WhatsApp abierto correctamente";
            }
            catch (Exception ex)
            {
                return $"Error al abrir WhatsApp: {ex.Message}";
            }
        }
        public string EnviarCorreo(string destinatario, string asunto, string cuerpo)
        {
            var correo = "marlonbuelvas314@gmail.com";
            try
            {
                MailMessage mensaje = new MailMessage();
                mensaje.From = new MailAddress(correo);
                mensaje.To.Add(destinatario);
                mensaje.Subject = asunto;
                mensaje.Body = cuerpo;
                mensaje.IsBodyHtml = false;

                SmtpClient clienteSmtp = new SmtpClient("smtp.gmail.com", 587);
                clienteSmtp.Credentials = new NetworkCredential(correo, "iouq qthg knmj kaju");
                clienteSmtp.EnableSsl = true;

                clienteSmtp.Send(mensaje);

                return"Correo enviado correctamente";
            }
            catch (Exception ex)
            {
                return $"Error al abrir WhatsApp: {ex.Message}";
            }
        }

    }
}
