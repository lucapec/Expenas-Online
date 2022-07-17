using System.ComponentModel.DataAnnotations;

namespace Expenas_Online.Models
{
    public class BuildingAddDto
    {
        [Required(ErrorMessage = "Agregue el piso donde se encuentran los departamentos")]
        [MaxLength(10)]
        public int Floor { get; set; }

    }
}
