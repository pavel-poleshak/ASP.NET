using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson_2_1.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Add(int? x, int? y)
        {
            if (x!=null && y!=null)
            {
                ViewBag.Result = x + y;
            }
            return View();
        }
        public ActionResult Mul(int? x, int? y)
        {
            if (x!=null && y!=null)
            {
                ViewBag.X = x;
                ViewBag.Y = y;
                ViewBag.Result = x * y;
            }
            return View();
        }
        public ActionResult Sub(int? x, int? y)
        {
            if (x!=null && y!=null)
            {
                ViewBag.Result = x - y;

            }
            return View();
        }
       
    }
}