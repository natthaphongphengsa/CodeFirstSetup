﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstSetup.Data
{
    public class Car
    {
        public int Id { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string RegNumber { get; set; }
        public decimal Price { get; set; }
        public bool HasRadio { get; set; }
    }
}
