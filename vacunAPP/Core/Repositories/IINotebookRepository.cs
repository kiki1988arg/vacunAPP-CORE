using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vacunAPP.Core.Domain;
using vacunAPP.ViewModels;

namespace vacunAPP.Core.Repositories
{
    public interface IINotebookRepository : IRepository<Notebook>
    {
        Task<IEnumerable<NextVaccineViewModel>> GetNextVaccines(string NIF);
        Task<int> GetNextVaccinesCount(string NIF);
    }
}

