﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lesson_1_1.Models
{
    public class Product
    {
        public int ProductID { get; private set; }
        public string  Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; } 
    }
}