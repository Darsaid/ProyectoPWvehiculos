using Microsoft.EntityFrameworkCore;
using ProyectoPWvehiculos.Models.Entities;

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
        public DbSet<Alquiler> Alquiler { get; set; }
    }
}
