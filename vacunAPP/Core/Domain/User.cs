using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vacunAPP.Core.Domain
{
    public class User
    {
        public string Email { get; set; }
        public string NIF { get; set; }
        public string password { get; set; } 
        public Person Person { get; set; }
    }
}
