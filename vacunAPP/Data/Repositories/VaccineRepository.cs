using Microsoft.EntityFrameworkCore;
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

        public async Task<IEnumerable<Vaccine>> GetPersonVaccines(string NIF)
        {
            var res = await(from vac in this._context.Vaccine
                            where (!this._context.Notebook.Any(f => f.Vaccine.Id == vac.Id && f.NIF == NIF))
                            select vac).ToListAsync();
            return res;

        }

    }


}
