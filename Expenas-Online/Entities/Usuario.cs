using Expenas_Online.Enums;
using System.ComponentModel.DataAnnotations;

namespace Expenas_Online.Entities
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(32)]
        public string? Password { get; set; }
        [Required]
        public string? UserName { get; set; }
        public TipoUsuario? Rol { get; set; }
    }
}
