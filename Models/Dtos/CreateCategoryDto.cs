using System;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models.Dtos;

public class CreateCategoryDto
{
    [Required(ErrorMessage = "El mensaje es obligatorio")]
    [MaxLength(50, ErrorMessage = "El nombre debe tener un maximo de 50 caracteres")]
    [MinLength(3, ErrorMessage = "El nombre debe tener un minimo de 3 caracteres")]
    public string Name { get; set; } = string.Empty;

}
