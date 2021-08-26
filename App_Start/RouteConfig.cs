using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Lab02
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "nhadat",
                url: "nha-dat",
                defaults: new { controller = "ChuyenMucNhaDat", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "chitietnhadat",
                url: "nha-dat/{alias}-{id}",
                defaults: new { controller = "ChuyenMucNhaDat", action = "ChiTiet", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
