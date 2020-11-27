using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vacunAPP.Core.Repositories;

namespace vacunAPP.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IVaccineRepository Vaccines {get;}
        IUserRepository User { get;}

        IPersonRepository Person { get; }
        IICenterRepository Institute { get; }
        IINotebookRepository Notebook { get; }
        IProfessionalRepository Professional { get; }

        int Complete();
    }
}
