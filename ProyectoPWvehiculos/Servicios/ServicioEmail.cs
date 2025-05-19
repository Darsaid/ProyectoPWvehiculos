using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using ProyectoPWvehiculos.Servicios;
using Microsoft.Extensions.Configuration;

namespace ProyectoPWvehiculos.Services
{
    public class ServicioEmail : IEmailSender
    {
        private readonly IConfiguration _configuration;

        public ServicioEmail(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task EnviarCorreo(string destinatario, string asunto, string mensaje)
        {
            var remitente = _configuration["Correo:Remitente"];
            var password = _configuration["Correo:Password"];
            var host = _configuration["Correo:Host"];
            var puerto = int.Parse(_configuration["Correo:Puerto"]);

            var client = new SmtpClient(host, puerto)
            {
                Credentials = new NetworkCredential(remitente, password),
                EnableSsl = true
            };

            var mailMessage = new MailMessage(remitente, destinatario, asunto, mensaje)
            {
                IsBodyHtml = false
            };

            await client.SendMailAsync(mailMessage);
        }
    }
}

