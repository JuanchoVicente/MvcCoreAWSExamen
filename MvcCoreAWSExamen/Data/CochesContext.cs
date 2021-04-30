using Microsoft.EntityFrameworkCore;
using MvcCoreAWSExamen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreAWSExamen.Data
{
    public class CochesContext : DbContext
    {
        public CochesContext(DbContextOptions<CochesContext> options)
            : base(options) { }

        public DbSet<Coche> Coches {get; set;}
    }
}
