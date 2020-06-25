using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuadroAvisos.Data
{
    public class AvisoContext : DbContext
    {
        public AvisoContext(DbContextOptions<AvisoContext> options):base(options)
        {

        }

        public DbSet<Aviso> Avisos { get; set; }
    }
}
