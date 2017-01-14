using Lesson_3_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson_3_2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult ShowContent()
        {
            List<Product> products = new List<Product>();
            for (int i = 0; i < 20; i++)
            {
                products.Add(new Product() { ID = i + 1, Name = "Product" + (i+1), Price = i * i * 2, CreatedDate = DateTime.Now });
            }
            return PartialView("_Content", products);
        }


    }
}