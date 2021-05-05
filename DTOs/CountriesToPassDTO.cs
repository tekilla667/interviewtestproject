using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace destination.DTOs
{
    public class CountriesToPassDTO
    {
        public string destination { get; set; }
        public IEnumerable<string> list { get; set; }
       
    }
}
