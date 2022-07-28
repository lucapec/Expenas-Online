using Expenas_Online.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expenas_Online.Entities
{
    public class Building
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }
        public ICollection<Floor> Floors { get; set; } = new List<Floor>();

        public Building(string nombre)
        {
            Nombre = nombre.Trim();
        }
    }
}
