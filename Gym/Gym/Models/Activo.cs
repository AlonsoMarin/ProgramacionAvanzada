using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Models
{
    public class Activo
    {
        [Key]

        public string IdActivo { get; set; }

        public string NombreProducto { get; set; }

        public int Cantidad { get; set; }

        public int Precio { get; set; }

      
    }
}
