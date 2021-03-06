﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vacunAPP.Core.Domain;

namespace vacunAPP.Core.Repositories
{
    public interface IVaccineRepository : IRepository<Vaccine>
    {
        Task<IEnumerable<Vaccine>> GetPersonVaccines(string NIF);
    }
}
