using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lesson_6_2.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public Decimal Price { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}