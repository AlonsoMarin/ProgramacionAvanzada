using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Models
{
    public class Usuario
    {
        [Key]
        public int IdUsuarios { get; set; }
        public int NombreUsuario { get; set; }
        public int Cedula { get; set; }
        public int Username { get; set; }
        public int Password { get; set; }



    }
}
