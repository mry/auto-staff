﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HMW.Core.Models
{
    public class Location
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public string Telephone { get; set; }
        public DateTime Created { get; set; }
    }
}
