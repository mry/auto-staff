using System;
using System.Collections;
using System.Collections.Generic;

namespace HMW.Core.Models
{
    public class Organization : ModelBase
    {
        public string Name { get; set; }
        public IList<Location> Locations { get; set; }
    }
}
