using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vacunAPP.Core.Domain
{
    public class Institute
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string CUIT { set; get; }
        public string License { set; get; }
        public string Contract { set; get; }
        public DateTime CreatedAt { set; get; }
        public ICollection<Professional> Profesionals { set; get; }
        public ICollection<Center> Centers { set; get; }
    }
}
