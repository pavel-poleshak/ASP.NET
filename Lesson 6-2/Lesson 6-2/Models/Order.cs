using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lesson_6_2.Models
{
    public class Order
    {
       public IEnumerable<Product> ProductList { get; set; }
        public int ProductsCount {
            get
            {
                return ProductList.Count();
            }
        }

    }
}