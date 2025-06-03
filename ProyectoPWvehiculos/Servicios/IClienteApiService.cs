using ProyectoPWvehiculos.Models.Entities;
using System.Reflection.PortableExecutable;

namespace ProyectoPWvehiculos.Servicios
{
    public class IClienteApiService
    {
        private readonly HttpClient _httpClient;

        public IClienteApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://localhost:7046/");
        }

        public async Task<List<Cliente>> GetAllAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Cliente>>("api/clientes");
        }

        public async Task<Cliente?> GetByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<Cliente>($"api/clientes/{id}");
        }

        public async Task<HttpResponseMessage> CreateAsync(Cliente clientes)
        {
            return await _httpClient.PostAsJsonAsync("api/clientes", clientes);
        }

        public async Task<HttpResponseMessage> UpdateAsync(int id, Cliente clientes)
        {
            return await _httpClient.PutAsJsonAsync($"api/clientes/{id}", clientes);
        }

        public async Task<HttpResponseMessage> DeleteAsync(int id)
        {
            return await _httpClient.DeleteAsync($"api/clientes/{id}");
        }
    }
}
