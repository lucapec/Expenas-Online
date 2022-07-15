using Expenas_Online.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expenas_Online.Entities
{
    public class Building
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Floor { get; set; }
        [Required]
        public ICollection<UnitDto> Units { get; set; } = new List<UnitDto>();
        

    }
}
