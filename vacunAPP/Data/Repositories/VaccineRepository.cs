using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vacunAPP.Core.Domain;
using vacunAPP.Core.Repositories;

namespace vacunAPP.Data.Repositories
{
    public class VaccineRepository : EfCoreRepository<Vaccine>, IVaccineRepository
    {
        public VaccineRepository(vacunAPPContext context) : base(context)
        {

        }
        // We can add new methods specific to the movie repository here in the future
    }


}
