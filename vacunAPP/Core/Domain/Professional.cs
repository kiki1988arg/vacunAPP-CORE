using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vacunAPP.Core.Domain
{
    public class Professional
    {
        public int Id { set; get; }
        public string MN { set; get; }
        public string Name { set; get; }
        public string LastName { set; get; }
        public string NIF { set; get; }
        public string Function { set; get; }
        public int InstituteId { set; get; }
        public string Email { set; get; }
        public string Password { set; get; }
    }
}
