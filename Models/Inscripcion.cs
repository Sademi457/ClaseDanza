using System.ComponentModel.DataAnnotations;

namespace EscuelaDanzaMVC.Models
{
    public class Inscripcion
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe ingresar un nombre")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 y 50 caracteres")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "Debe seleccionar una clase")]
        public string Clase { get; set; } = string.Empty;

    }
}