﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson_1_1.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult List()
        {
            return View();
        }
        public ActionResult Details()
        {
            return View();
        }
    }
}