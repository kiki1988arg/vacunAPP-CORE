using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vacunAPP.Core;
using vacunAPP.Core.Repositories;
using vacunAPP.Data.Repositories;

namespace vacunAPP.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly vacunAPPContext _context;

        public IVaccineRepository Vaccines { get; }
        public IUserRepository User { get; }
        public IICenterRepository Institute { get; }
        public IPersonRepository Person { get; }
        public IINotebookRepository Notebook { get; }
        public IProfessionalRepository Professional { get; }



        public UnitOfWork(vacunAPPContext vacunAPPContext)
        {
            this._context = vacunAPPContext;
            this.Vaccines = new VaccineRepository(_context);
            this.User = new UserRepository(_context);
            this.Institute = new CenterRepository(_context);
            this.Person = new PersonRepository(_context);
            this.Notebook = new NotebookRepository(_context);
            this.Professional = new ProfessionalRepository(_context);
        }
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
    }
}
