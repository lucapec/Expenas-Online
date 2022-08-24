using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpensasOnline.API.Entities
{
    public class Piso
    {
        [Key] //Esto es opcional si se sigue la convención
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //También por convención no hace falta. Identity genera un nuevo Id por cada creación.
        public int Id { get; set; }
        [Required]

        public ICollection<Unidad> Unidad { get; set; } = new List<Unidad>(); //Lo seteamos a una nueva colección para evitar que retorne un null en algún momento de la ejecución.

     
    }
}
