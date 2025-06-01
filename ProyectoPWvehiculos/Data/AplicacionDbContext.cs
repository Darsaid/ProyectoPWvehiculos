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
        public DbSet<Vehiculo> Vehiculo { get; set; }
        public DbSet<ProyectoPWvehiculos.Models.Alquiler> Alquiler { get; set; }
    }
}
