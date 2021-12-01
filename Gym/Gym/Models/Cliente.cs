using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Models
{
    public class Cliente
    {
        [Key]

        public int IdCliente { get; set; }

        public string Nombre { get; set; }

        public string Cedula { get; set; }

        public int Edad { get; set; }

        public string Genero { get; set; }

        public string Direccion { get; set; }

        public string Celular { get; set; }

        public string Estatura { get; set; }

        public int  Peso { get; set; }



    }
}
