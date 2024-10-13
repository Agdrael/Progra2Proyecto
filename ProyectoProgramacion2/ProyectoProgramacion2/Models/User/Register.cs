using System.ComponentModel.DataAnnotations;

namespace ProyectoProgramacion2.Models.User
{
    public class Register : UserTemplate
    {
        [Required]
        [DataType(DataType.Password)]
        [Compare("UserPassword", ErrorMessage = "Las contraseñas con son iguales.")]
        public string? ConfirmPassword { get; set; }
    }
}
