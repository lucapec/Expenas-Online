﻿using System.ComponentModel.DataAnnotations;

namespace ExpensasOnline.API.Models
{
    public class UnidadParaUpdateDto
    {
        [Required(ErrorMessage = "Agreue el nombre del inquilino")]
        [MaxLength(50)]
        public string Nombre { get; set; } = string.Empty;
        [MaxLength(500)]

        [Required(ErrorMessage = "Agregue la deuda del inquilino")]
        public float? Deuda { get; set; }
    }
}