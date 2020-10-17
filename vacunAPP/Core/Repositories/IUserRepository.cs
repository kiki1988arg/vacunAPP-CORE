using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vacunAPP.Core.Domain;
using vacunAPP.ViewModels;

namespace vacunAPP.Core.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> GetUserProfile(string userName);
    }
}
