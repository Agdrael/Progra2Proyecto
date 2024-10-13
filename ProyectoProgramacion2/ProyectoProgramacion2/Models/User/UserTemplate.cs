using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProyectoProgramacion2.Models.User
{
    public abstract class UserTemplate
    {
        [Required]
        [EmailAddress]
        [DisplayName("Correo")]
        public string? UserEmail { get; set; } 
        [Required]
        [DataType(DataType.Password)]
        [DisplayName("Contraseña")]
        public string? UserPassword { get; set; } 
    }
}
