using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpensasOnline.API.Entities
{
    public class Unidad
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }
        
        public float? Deuda { get; set; } 

        [ForeignKey("PisoId")]
        public Piso? Piso { get; set; }
        public int PisoId { get; set; }
        public Unidad(string nombre)
        {
            Nombre = nombre;
        }
    }
}
