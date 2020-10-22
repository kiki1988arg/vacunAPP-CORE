using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vacunAPP.Core.Domain;
using vacunAPP.Core.Repositories;

namespace vacunAPP.Data.Repositories
{
    public class InstituteRepository : EfCoreRepository<Institute>, IInstituteRepository
    {
        public InstituteRepository(vacunAPPContext context) : base(context)
        {

        }
    }
}
