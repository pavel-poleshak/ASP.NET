using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson_4_2.Controllers
{
    public class HomeController : Controller
    {
        //GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult News()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string Login, string Password)
        {
            if (Login == "1" && Password=="1")
            {
                ViewBag.Message = "Вы авторизовались";
            }
            return View();
        }
        public ActionResult Registration()
        {
            return View();
        }

    }
}