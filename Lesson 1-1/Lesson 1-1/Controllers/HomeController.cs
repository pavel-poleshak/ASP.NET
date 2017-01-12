using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson_1_1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //public ActionResult Index()
        //{           
        //    return View();
        //}

        public ActionResult Index(int? x, int? y)
        {
            if (x!=null && y!=null)
            {
                ViewBag.Result = x+y;
            }
            
            return View("Index");
        }
    }
}