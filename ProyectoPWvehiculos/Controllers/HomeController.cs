using System.Diagnostics;
using System.Threading.Tasks;
using ProyectoPWvehiculos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProyectoPWvehiculos.ViewModels;
using ProyectoPWvehiculos.Servicios;
using ProyectoPWvehiculos.Models;

namespace ProyectoPWvehiculos.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmailSender _emailSender;

        public HomeController(ILogger<HomeController> logger, IEmailSender emailSender)
        {
            _logger = logger;
            _emailSender = emailSender;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contacto()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Contacto(ContactoViewModel modelo)
        {
            if (!ModelState.IsValid)
                return View(modelo);

            await _emailSender.EnviarCorreo(modelo.Email, "Mensaje recibido", modelo.Mensaje);
            ViewBag.Mensaje = "Correo enviado exitosamente.";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
