using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vacunAPP.Core.Domain;
using vacunAPP.Core.Repositories;

namespace vacunAPP.Data.Repositories
{
    public class UserRepository : EfCoreRepository<User>, IUserRepository
    {
        public UserRepository(vacunAPPContext context) : base(context)
        {

        }
        public async Task<User> GetUserProfile(User profile)
        {
            var ProfileData = await this.Get(profile.Id);
            if(ProfileData != null)
            {                
                await this.Add(profile);
            }
            return ProfileData;
        }
    }
}
