﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ProductType ProductType { get; set; }
        public double Price { get; set; }
    }
}
