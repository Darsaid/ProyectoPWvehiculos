using Microsoft.AspNetCore.Mvc;
using ProyectoPWvehiculos.Models;

namespace ProyectoPWvehiculos.Controllers
{
    public class VehiculoController : Controller
    {
        private readonly IRepositorioVehiculos repositorioVehiculos;

        public VehiculoController(IRepositorioVehiculos repositorioVehiculos)
        {
            this.repositorioVehiculos = repositorioVehiculos;
        }

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Vehiculo vehiculo)
        {
            if (!ModelState.IsValid)
            {
                return View(vehiculo);
            }

            //vehiculo.VehiculoId = 1;
            repositorioVehiculos.Crear(vehiculo);

            return View();
        }
    }
}
