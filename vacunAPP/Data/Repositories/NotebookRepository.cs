using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vacunAPP.Core.Domain;
using vacunAPP.Core.Repositories;

namespace vacunAPP.Data.Repositories
{
    public class NotebookRepository : EfCoreRepository<Notebook>, IINotebookRepository
    {
        public NotebookRepository(vacunAPPContext context) : base(context)
        {
        }
    }
}
