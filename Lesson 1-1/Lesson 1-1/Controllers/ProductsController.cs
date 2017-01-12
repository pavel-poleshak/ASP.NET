using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lesson_1_1.Models;

namespace Lesson_1_1.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult List()
        {
            List<Product> myList = new List<Product>()
            {
                new Product()
                {

                    Name ="Мыло",
                    Description ="Мыло жидкое",
                    Price =100M
                },
                new Product()
                {
                    Name="Грабли",
                    Description="Зубчатые",
                    Price = 140M
                }
            };
            return View(myList);

        }
            
        
        public ActionResult Details()
        {
            return View();
        }
    }
}