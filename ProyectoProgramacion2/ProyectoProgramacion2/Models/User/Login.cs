using System.ComponentModel.DataAnnotations;

namespace ProyectoProgramacion2.Models.User
{
    public class Login : UserTemplate
    {
        [Required]
        public bool RememberMe { get; set; }
    }
}
