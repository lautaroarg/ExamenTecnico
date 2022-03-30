using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Brazor.Data
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        [Required(ErrorMessage ="El Username es obligatorio")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }
        [RegularExpression("^([a-zA-Z0-9_\\.]+)@([a-zA-Z0-9_\\.]+)\\.([a-zA-Z]{2,5})$", ErrorMessage ="Debes indicar un email valido")]
        public string Email { get; set; }
        public string Telefono { get; set; }
    }
}
