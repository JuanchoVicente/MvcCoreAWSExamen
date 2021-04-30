using MvcCoreAWSExamen.Data;
using MvcCoreAWSExamen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreAWSExamen.Repositories
{
    public class RepositoryCoches
    {
        CochesContext context;

        public RepositoryCoches(CochesContext context)
        {
            this.context = context;
        }

        public List<Coche> GetCoches()
        {
            return this.context.Coches.ToList();
        }

    }
}
