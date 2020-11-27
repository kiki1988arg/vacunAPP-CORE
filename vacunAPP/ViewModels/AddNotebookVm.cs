using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vacunAPP.ViewModels
{
    public class AddNotebookVm
    {
        public int Id { set; get; }
        public DateTime ApplicationDate { set; get; }
        public string NIF { set; get; }
        public int VaccineId { set; get; }
        public int CenterId { set; get; }
        public int ProfessionalId { set; get; }
    }
}
