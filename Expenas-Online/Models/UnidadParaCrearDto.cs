using System.ComponentModel.DataAnnotations;

namespace ExpensasOnline.API.Models
{
    public class UnidadParaCrearDto
    {
        [Required(ErrorMessage = "Agreue el nombre del inquilino")]
        [MaxLength(50)]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "Agregue la deuda del inquilino")]
        public float? Deuda { get; set; }
    }
}

