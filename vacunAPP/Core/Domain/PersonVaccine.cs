using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vacunAPP.Core.Domain
{
    public class PersonVaccine
    {
        public int PersonId { set; get; }
        public int VaccineId { set; get; }
        public Person Person { set; get; }
        public Vaccine Vaccine { set; get; }
    }
}
