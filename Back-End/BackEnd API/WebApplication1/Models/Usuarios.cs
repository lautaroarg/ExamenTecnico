using System.ComponentModel.DataAnnotations;


namespace WebApplication1.Models
{
    public class Usuarios
    {
        [Key]
        public int IdUsuario { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Email { get; set; }
        public string Telefono { get; set; }
    }
}
