using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vacunAPP.Core.Domain
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string NIF { get; set; }
        public string Gender { get; set; }
        public DateTime BornDate { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }         
        public ICollection<PersonVaccine> PersonVaccine { get; set; }
    }
}
