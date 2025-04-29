using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FeijooJ_Progreso1.Models;

namespace FeijooJ_Progreso1.Data
{
    public class FeijooJ_Progreso1Context : DbContext
    {
        public FeijooJ_Progreso1Context (DbContextOptions<FeijooJ_Progreso1Context> options)
            : base(options)
        {
        }

        public DbSet<FeijooJ_Progreso1.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<FeijooJ_Progreso1.Models.Reserva> Reserva { get; set; } = default!;
    }
}
