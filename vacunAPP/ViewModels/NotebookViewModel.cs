using System;

namespace vacunAPP.ViewModels
{
    public class NotebookViewModel
    {
        public int Id { set; get; }
        public DateTime ApplicationDate { set; get; }
        public string NIF { set; get; }
        public VaccineViewModel Vaccine { set; get; }
        public CenterViewModel Center { set; get; }
        public ProfessionalViewModel Professional { set; get; }
        public PersonViewModel Person { set; get; }
    }
}