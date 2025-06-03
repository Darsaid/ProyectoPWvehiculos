using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using ProyectoPWvehiculos.Models.Entities;


namespace ProyectoPWvehiculos.Servicios
{
    public class RepositorioVehiculos : IRepositorioVehiculos
    {
        private readonly string cadenaConexion;

        public RepositorioVehiculos(IConfiguration configuration)
        {
            cadenaConexion = configuration.GetConnectionString("DefaultConnection");
        }

        public void Crear(Vehiculo vehiculo)
        {
            using var conexion = new SqlConnection(cadenaConexion);
            var id = conexion.QuerySingle<int>($@"INSERT INTO Vehiculo (Placa, Marca, Modelo, Año, Tipo, PrecioPorDia, Estado)
                                                    VALUES (@Placa, @Marca, @Modelo, @Año, @Tipo, @PrecioPorDia, @Estado);
                                                    SELECT SCOPE_IDENTITY();", vehiculo);

            vehiculo.VehiculoId = id;
        }
    }
}
