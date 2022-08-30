using System.ComponentModel.DataAnnotations;

namespace Expenas_Online.Models
{
    public class AutenticacionRequestBody
    {
        [Required]
        public string? UserName { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
