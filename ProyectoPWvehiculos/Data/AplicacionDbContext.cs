using Microsoft.EntityFrameworkCore;
using ProyectoPWvehiculos.Models;

namespace ProyectoPWvehiculos.Data
{
    public class AplicacionDbContext : DbContext
    {
        public AplicacionDbContext(DbContextOptions<AplicacionDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
