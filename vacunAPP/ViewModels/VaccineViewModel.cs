using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vacunAPP.ViewModels
{
    public class VaccineViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Inyection { get; set; }
        public int Month { get; set; }
        public string ApplicationType { get; set; }
        public string ExtraInfo { get; set; }
    }
}
