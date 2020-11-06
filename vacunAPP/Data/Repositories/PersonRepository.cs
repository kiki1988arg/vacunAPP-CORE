using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vacunAPP.Core.Domain;
using vacunAPP.Core.Repositories;

namespace vacunAPP.Data.Repositories
{
    public class PersonRepository : EfCoreRepository<Person>, IPersonRepository
    {
        public PersonRepository(vacunAPPContext context) : base(context)
        {

        }

        public Task<Person> GetPersonByNIF(string NIF)
        {
            return _context.Person
                .Include(c=>c.Notebooks).ThenInclude(d=>d.Vaccine)
                .Include(d=>d.Notebooks).ThenInclude(d => d.Center)
                .SingleAsync(c => c.NIF == NIF);
        }

        async Task<IEnumerable<Person>> IPersonRepository.GetPersonsById(string Id)
        {
            return await _context.Person.Where(c => c.ParentPersonNIF == Id).ToListAsync();
        }
    }
}
