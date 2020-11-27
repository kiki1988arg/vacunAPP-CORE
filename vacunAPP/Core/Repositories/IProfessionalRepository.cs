using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vacunAPP.Core.Domain;
using vacunAPP.ViewModels;

namespace vacunAPP.Core.Repositories
{
    public interface IProfessionalRepository : IRepository<Professional>
    {
        Task<Professional> GetProfessionalProfile(string userName);
    }
}
