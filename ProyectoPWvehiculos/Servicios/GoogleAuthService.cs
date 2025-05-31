using Microsoft.AspNetCore.Authentication;

namespace ProyectoPWvehiculos.Servicios
{
    public class GoogleAuthService : IAuthService
    {
        public async Task ChallengeGoogleLoginAsync(HttpContext context)
        {
            var properties = new AuthenticationProperties
            {
                RedirectUri = "/Account/ExternalLoginCallback"
            };

            await context.ChallengeAsync("Google", properties);
        }
    }
}
