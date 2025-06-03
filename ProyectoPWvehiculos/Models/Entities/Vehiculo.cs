using System.ComponentModel.DataAnnotations;

namespace ProyectoPWvehiculos.Models.Entities
{
    public class Vehiculo
    {
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int VehiculoId { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength: 7, MinimumLength = 6, ErrorMessage = "La longitud del campo {0} debe estar entre {2} y {1}")]
        [Display(Name = "Placa")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(50, ErrorMessage = "La {0} no debe superar los 50 caracteres.")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(50, ErrorMessage = "El {0} no debe superar los 50 caracteres.")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Range(1950, 2100, ErrorMessage = "El {0} debe estar entre 1950 y 2100.")]
        public int Año { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(30, ErrorMessage = "El {0} no debe superar los 30 caracteres.")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Range(0, 999999.99, ErrorMessage = "El {0} debe ser un número positivo.")]
        [DataType(DataType.Currency)]
        public decimal PrecioPorDia { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [RegularExpression("Disponible|Rentado|Mantenimiento", ErrorMessage = "Estado inválido.")]
        public string Estado { get; set; }

    }
}
