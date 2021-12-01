using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Models
{
    public class Pagos
    {
        [Key]

        public int IdPagos { get; set; }

        public int IdMensualidad { get; set; }

        public string Comprobante { get; set; }

        public string Estado { get; set; }

    }
}
