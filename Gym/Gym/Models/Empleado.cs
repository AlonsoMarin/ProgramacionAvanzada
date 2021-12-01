using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Models
{
    public class Empleado
    {
        [Key]
        public int IdEmpleado { get; set; }
        public string NombreEmpleado { get; set; }
        public string Cedula { get; set; }
        public string Celular { get; set; }
        public int IdHorario { get; set; }



    }
}
