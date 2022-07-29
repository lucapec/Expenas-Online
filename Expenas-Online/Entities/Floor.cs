using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expenas_Online.Entities
{
    public class Floor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        public float Debt { get; set; } 

        [ForeignKey("BuildingId")]

        public Building Building { get; set; }

        public Floor(string nombre)
        {
            Nombre = nombre;
        }

        public Floor()
        {
        }
    }
}
