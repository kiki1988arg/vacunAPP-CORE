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

        async Task<IEnumerable<Person>> IPersonRepository.GetPersonsById(int Id)
        {
            return await _context.Person.Where(c => c.UserId == Id).ToListAsync();
        }
    }
}
