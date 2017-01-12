using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Lesson_2_1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
               name: "CalcController",
               url: "{controller}/{action}/{x}/{y}",
               defaults: new { controller = "Home", action = "Index", x=0, y=0}
           );
        }
    }
}
