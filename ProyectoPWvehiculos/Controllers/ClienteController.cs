using Microsoft.AspNetCore.Mvc;

namespace ProyectoPWvehiculos.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
