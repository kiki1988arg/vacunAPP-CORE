﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vacunAPP.Core.Domain
{
    public class Notebook
    {
        public int Id { set; get; }
        public DateTime ApplicationDate { set; get; }
        public string NIF { set; get; }
        public int VaccineId { set; get; }
        public Vaccine Vaccine { set; get; }
        public int CenterId { set; get; }
        public Center Center { set; get; }
        public int ProfessionalId { set; get; }
        public Professional Professional { set; get; }
        public Person Person { set; get; }
    }
}
