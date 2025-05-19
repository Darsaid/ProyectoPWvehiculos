namespace ProyectoPWvehiculos.Servicios
{
    public interface IEmailSender
    {
        Task EnviarCorreo(string destinatario, string asunto, string mensaje);
    }
}
