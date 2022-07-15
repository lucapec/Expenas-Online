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
        public string Name { get; set; }

        public Floor(string name)
        {
            Name = name;
        }

        [Required]
        public float Debt { get; set; } //Buscar como ahcer que esto no ´púeda ser 0
        [Required]

        [ForeignKey("BuildingFloor")]

        public Building Building { get; set; }

        public int BuildingFloor { get; set; }
    }
}
