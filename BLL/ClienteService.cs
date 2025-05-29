using DAL;
using Entity;
using Entity.Dto;
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
                    return "El cliente no puede ser nulo.";

                if (string.IsNullOrWhiteSpace(cliente.Nombre))
                    return "El nombre del cliente es obligatorio.";

                if (string.IsNullOrWhiteSpace(cliente.Telefono))
                    return "El teléfono del cliente es obligatorio.";

                if (!string.IsNullOrWhiteSpace(cliente.Email) && !cliente.Email.Contains("@"))
                    return "El email del cliente no es válido.";

                return _clienteRepository.Agregar(cliente);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la lógica de negocio al agregar cliente", ex);
            }
        }
        public string Actualizar(Cliente cliente)
        {
            try
            {
                if (cliente == null)
                    throw new AppException("El cliente no puede ser nulo.");

                if (cliente.Id <= 0)
                    throw new AppException("ID de cliente inválido.");

                if (string.IsNullOrWhiteSpace(cliente.Nombre))
                    throw new AppException("El nombre del cliente es obligatorio.");

                if (string.IsNullOrWhiteSpace(cliente.Telefono))
                    throw new AppException("El teléfono del cliente es obligatorio.");

                if (!string.IsNullOrWhiteSpace(cliente.Email) && !cliente.Email.Contains("@"))
                    throw new AppException("El email del cliente no es válido.");

                return _clienteRepository.Update(cliente);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la lógica de negocio al actualizar cliente", ex);
            }
        }
        public string Delete(int id)
        {
            try
            {
                if (id <= 0)
                    throw new AppException("ID de cliente inválido.");

                return _clienteRepository.Delete(id);
            }
            catch (Exception ex)
            {
                throw new AppException("Error en la lógica de negocio al eliminar cliente", ex);
            }
        }
        public List<Cliente> GetAll()
        {
            try
            {
                return _clienteRepository.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la lógica de negocio al obtener todos los clientes", ex);
            }
        }
        public Cliente GetById(int id)
        {
            try
            {
                if (id <= 0)
                    throw new Exception("ID de cliente inválido.");

                return _clienteRepository.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la lógica de negocio al obtener cliente por ID", ex);
            }
        }
        public List<Reserva> ObtenerReservasPorCliente(int idCliente)
        {
            try
            {
                if (idCliente <= 0)
                    throw new AppException("ID de cliente inválido.");

                return _clienteRepository.ObtenerReservas(idCliente);
            }
            catch (Exception ex)
            {
                throw new AppException("Error al obtener reservas del cliente", ex);
            }
        }
        public List<Despacho> ObtenerDespachosPorCliente(int idCliente)
        {
            try
            {
                if (idCliente <= 0)
                    throw new AppException("ID de cliente inválido.");

                return _clienteRepository.ObtenerDespachos(idCliente);
            }
            catch (Exception ex)
            {
                throw new AppException("Error al obtener despachos del cliente", ex);
            }
        }
        public List<PagoDto> ObtenerPagosPorCliente(int idCliente)
        {
            try
            {
                if (idCliente <= 0)
                    throw new AppException("ID de cliente inválido.");

                return _clienteRepository.ObtenerPagos(idCliente);
            }
            catch (Exception ex)
            {
                throw new AppException("Error al obtener pagos del cliente", ex);
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

                return "Correo enviado correctamente";
            }
            catch (Exception ex)
            {
                return $"Error al abrir WhatsApp: {ex.Message}";
            }
        }
        public ClienteDTO ObtenerClientePorTelefono(string telefono)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(telefono))
                    throw new AppException("El teléfono es obligatorio.");

                string soloDigitos = new string(telefono.Where(char.IsDigit).ToArray());
                if (soloDigitos.Length > 10)
                    throw new AppException("El teléfono no debe tener más de 10 dígitos.");

                return _clienteRepository.GetByTelefono(telefono);
            }
            catch (Exception ex)
            {
                throw new AppException("Error al obtener cliente por teléfono", ex);
            }
        }

    }
}
