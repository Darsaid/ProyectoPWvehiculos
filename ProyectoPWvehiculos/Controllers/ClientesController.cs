using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ProyectoPWvehiculos.Models;
using System.Text;

namespace ProyectoPWvehiculos.Controllers
{
    public class ClientesController : Controller
    {
        private readonly HttpClient _httpClient;
        private object _context;

        public ClientesController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7117/api/");
        }

        // GET: /Clientes
        public async Task<IActionResult> Index()
        {
            var response = await _httpClient.GetAsync("clientes");
            if (!response.IsSuccessStatusCode)
            {
                return View("Error");
            }

            var json = await response.Content.ReadAsStringAsync();
            var clientes = JsonConvert.DeserializeObject<List<Cliente>>(json);

            return View(clientes);
        }

        // GET: /Clientes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Cliente cliente)
        {
            if (!ModelState.IsValid)
            {
                return View(cliente);
            }

            var jsonContent = new StringContent(JsonConvert.SerializeObject(cliente), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("clientes", jsonContent);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }

            // Si hay error en la API, mostramos error
            ModelState.AddModelError(string.Empty, "Error al guardar el cliente.");
            return View(cliente);
        }
    }
}

