using System.ComponentModel.DataAnnotations; //To implemenst action of valitacion.
using System.ComponentModel.DataAnnotations.Schema;


namespace ProyectoProgramacion2.Models
{
    public class UserModel
    {
        public int ID { get; set; }

        public string? Nombre { get; set; }

        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}(\.[A-Za-z]{2,4})?"), Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
