using System.ComponentModel.DataAnnotations;

namespace Expenas_Online.Models
{
    public class FloorAddDto
    {
        [Required(ErrorMessage = "Agregue el nombre y apellido del inquilino")]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Ingrese el monto de deuda del inquilino")]
        public float Debt { get; set; }
    }
}
