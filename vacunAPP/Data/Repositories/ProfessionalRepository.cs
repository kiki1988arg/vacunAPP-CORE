using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vacunAPP.Core.Domain;
using vacunAPP.Core.Repositories;
using vacunAPP.ViewModels;

namespace vacunAPP.Data.Repositories
{
    public class ProfessionalRepository : EfCoreRepository<Professional>, IProfessionalRepository
    {
        public ProfessionalRepository(vacunAPPContext context) : base(context)
        {

        }
        public async Task<Professional> GetProfessionalProfile(string userName)
        {
            Professional prof = await this._context.Profesional
                    .Where(b => b.Email.ToUpper() == userName.ToUpper()).FirstOrDefaultAsync();
            return prof;

        }
    }
}
