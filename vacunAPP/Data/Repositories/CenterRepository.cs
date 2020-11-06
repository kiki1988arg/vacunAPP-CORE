using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vacunAPP.Core.Domain;
using vacunAPP.Core.Repositories;

namespace vacunAPP.Data.Repositories
{
    public class CenterRepository : EfCoreRepository<Center>, IICenterRepository
    {
        public CenterRepository(vacunAPPContext context) : base(context)
        {

        }
    }
}
