using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace UKSAquator
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "NewsDetails",
                url: "wydarzenia-{id}.html",
                defaults: new { controller = "News", action = "Details"}
            );

            routes.MapRoute(
                name: "NewsList",
                url: "wydarzenia",
                defaults: new { controller = "News", action = "List"}
            );

            routes.MapRoute(
                name: "Gallery",
                url: "galeria",
                defaults: new { controller = "Home", action = "Gallery" }
            );

            routes.MapRoute(
                name: "StaticPages",
                url: "strony/{viewname}.html",
                defaults: new { controller = "Home", action = "StaticContent"}
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
