using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using ProyectoPWvehiculos.Servicios;

namespace ProyectoPWvehiculos.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAuthService _authService;

        public AccountController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            if (email == "prueba@email.com" && password == "123456")
            {
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "Credenciales incorrectas";
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ExternalLogin(string provider)
        {
            if (provider == "Google")
            {
                await _authService.ChallengeGoogleLoginAsync(HttpContext);
                return new EmptyResult();
            }

            return RedirectToAction("Login");
        }

        [HttpGet]
        public IActionResult ExternalLoginCallback()
        {
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(string fullName, string email, string password, string confirmPassword)
        {
            if (password != confirmPassword)
            {
                ViewBag.Error = "Las contraseñas no coinciden";
                return View();
            }

            return RedirectToAction("Login");
        }
    }
}
