using System.ComponentModel.DataAnnotations;

namespace ProyectoPWvehiculos.Models
{
    public class ContactoViewModel
    {
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio.")]
        [EmailAddress(ErrorMessage = "Ingrese un correo válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El mensaje no puede estar vacío.")]
        [StringLength(500, ErrorMessage = "El mensaje no puede superar los 500 caracteres.")]
        public string Mensaje { get; set; }
    }
}
