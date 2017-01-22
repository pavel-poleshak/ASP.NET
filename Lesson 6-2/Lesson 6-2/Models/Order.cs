using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lesson_6_2.Models
{
    public class Order
    {
        public int OrderID { get; set; }
       public IEnumerable<Product> ProductList { get; set; }
        public int ProductsCount
        {
            get
            {
                return ProductList.Count();
            }
        }
        public DateTime BuyingDate
        {
            get
            {
                return DateTime.Now;
            }
        }
        public User User { get; set; }

    }
}