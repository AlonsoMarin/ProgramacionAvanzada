using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gym.Models;

namespace Gym.Data
{
    public class GymContext : DbContext
    {
        public GymContext (DbContextOptions<GymContext> options)
            : base(options)
        {
        }

        public DbSet<Gym.Models.Activo> Activo { get; set; }

        public DbSet<Gym.Models.Cliente> Cliente { get; set; }

        public DbSet<Gym.Models.Empleado> Empleado { get; set; }

        public DbSet<Gym.Models.Mensualidad> Mensualidad { get; set; }

        public DbSet<Gym.Models.Pagos> Pagos { get; set; }

        public DbSet<Gym.Models.Usuario> Usuario { get; set; }
    }
}
