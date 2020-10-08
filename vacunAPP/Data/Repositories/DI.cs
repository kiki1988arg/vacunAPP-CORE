using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vacunAPP.Core;
using vacunAPP.Core.Repositories;

namespace vacunAPP.Data.Repositories
{
    public static class DI
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddTransient<IVaccineRepository, VaccineRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
