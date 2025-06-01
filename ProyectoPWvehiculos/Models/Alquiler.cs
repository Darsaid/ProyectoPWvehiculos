namespace ProyectoPWvehiculos.Models
{
    public class Alquiler
    {
        public int AlquilerId { get; set; }
        public required int VehiculoId { get; set; }
        public required int ClienteId { get; set; }
        public required DateTime FechaInicio { get; set; }
        public required DateTime FechaFin { get; set; }
        public required string Estado { get; set; }
        public required string FormaDePago { get; set; }
        public string Observaciones { get; set; }
        public required DateTime FechaRegistro { get; set; }
    }
}
