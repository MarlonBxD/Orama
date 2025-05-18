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
    public class ClienteSerive
    {
        private readonly CLienteRepository _clienteRepository;
        public ClienteSerive()
        {
            _clienteRepository = new CLienteRepository();
        }
        public string AgregarCliente(Cliente cliente)
        {
            try
            {
                _clienteRepository.AgregarCliente(cliente);
                return "Cliente agregado correctamente";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
        public List<Cliente> GetClientes()
        {
            try
            {
                return _clienteRepository.GetClientes();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener los clientes: {ex.Message}");
            }
        }
        public string DeleteCliente(int id)
        {
            try
            {
                _clienteRepository.DelecteClienteById(id);
                return "Error al eliminar el cliente";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
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
