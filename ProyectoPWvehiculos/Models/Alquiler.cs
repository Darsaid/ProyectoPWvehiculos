namespace ProyectoPWvehiculos.Models
{
    public class Alquiler
    {
        public int AlquilerId { get; set; }
        public int VehiculoId { get; set; }
        public int ClienteId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; }
        public string FormaDePago { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
