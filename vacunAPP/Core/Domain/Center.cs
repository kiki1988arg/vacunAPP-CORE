using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vacunAPP.Core.Domain
{
    public class Center
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Address { set; get; }
        public string Locale { set; get; }
        public string Time { set; get; }
        public string Lat { set; get; }
        public string Long { set; get; }
        public string Phone { set; get; }
    }
}
