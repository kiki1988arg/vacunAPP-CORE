using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vacunAPP.ViewModels
{
    public class PersonViewModel
    {
        public string NIF { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime BornDate { get; set; }
        public string ParentPersonNIF { get; set; }
        public PersonViewModel ParentPerson { get; set; }
        public ICollection<NotebookViewModel> Notebooks { get; set; }
        public IEnumerable<VaccineViewModel> Vaccines { get; set; }
    }
}

