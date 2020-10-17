using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vacunAPP.Core.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string NIF { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string password { get; set; }
        public string PhotoUrl { get; set; }
        public DateTime BornDate { get; set; }
        public bool IsVerify { get; set; }
    }
}
