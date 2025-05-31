namespace ProyectoPWvehiculos.Servicios
{
    public interface IAuthService
    {
        Task ChallengeGoogleLoginAsync(HttpContext httpContext);
    }
}
