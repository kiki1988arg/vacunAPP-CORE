using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vacunAPP.Core.Domain
{
    public class Vaccine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Inyection { get; set; }
        public int Month { get; set; }
        public string ApplicationType { get; set; }
        public string ExtraInfo { get; set; }
    }
}
