using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace destination.Core
{
    public class Country
    {
        public Country(string shortName, Country parent)
        {
            this.shortName = shortName;
            this.parent = parent;
        }

        public string shortName { get; set; }

        public Country parent { get; set; }
    }
}
