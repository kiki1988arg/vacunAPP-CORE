﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vacunAPP.Core.Repositories;

namespace vacunAPP.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IVaccineRepository Vaccines {get;}
        int Complete();
    }
}
