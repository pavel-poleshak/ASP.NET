using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lesson_6_2.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime RegisterDate { get; set; }
        public string Email { get; set; }
        public IEnumerable<Order> OrderList { get; set; }
     
    }
}