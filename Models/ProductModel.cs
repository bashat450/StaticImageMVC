﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcProducts.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public double Price { get; set; }
    }
}