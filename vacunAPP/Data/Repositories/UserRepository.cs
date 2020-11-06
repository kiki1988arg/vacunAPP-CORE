using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vacunAPP.Core.Domain;
using vacunAPP.Core.Repositories;
using vacunAPP.ViewModels;

namespace vacunAPP.Data.Repositories
{
    public class UserRepository : EfCoreRepository<User>, IUserRepository
    {
        public UserRepository(vacunAPPContext context) : base(context)
        {

        }
        public async Task<User> GetUserProfile(string userName)
        {
            User User = await (this._context.User
                    .Where(b => b.Email.ToUpper() == userName.ToUpper())
                    .Include(s=>s.Person).FirstOrDefaultAsync());
            return User;

        }
    }
}
