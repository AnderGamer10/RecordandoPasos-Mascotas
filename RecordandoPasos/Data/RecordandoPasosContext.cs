using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecordandoPasos.Models;

namespace RecordandoPasos.Data
{
    public class RecordandoPasosContext : DbContext
    {
        public RecordandoPasosContext (DbContextOptions<RecordandoPasosContext> options)
            : base(options)
        {
        }

        public DbSet<RecordandoPasos.Models.Usuarios> Usuarios { get; set; }

        public DbSet<RecordandoPasos.Models.Mascota> Mascota { get; set; }
    }
}
