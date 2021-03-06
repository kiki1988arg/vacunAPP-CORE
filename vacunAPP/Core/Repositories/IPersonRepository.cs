﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vacunAPP.Core.Domain;

namespace vacunAPP.Core.Repositories
{
    public interface IPersonRepository : IRepository<Person>
    {
        Task <IEnumerable<Person>> GetPersonsById(string Id);
        Task<Person> GetPersonByNIF(string NIF);


    }
}
