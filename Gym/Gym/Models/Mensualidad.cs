using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Models
{
    public class Mensualidad
    {
        [Key]
        public int IdMensualidad { get; set; }

        public int IdCliente { get; set; }

        public DateTime FechaInicio { get; set; }

        public int Precio  { get; set; }
    }
}
