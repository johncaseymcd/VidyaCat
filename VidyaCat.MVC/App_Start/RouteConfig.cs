using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace VidyaCat.MVC
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
                name: "Region",
                url: "{controller}/{action}/{region}"
            );

            routes.MapRoute(
                name: "Status",
                url: "{controller}/{action}/{status}"
            );

            routes.MapRoute(
                name: "Type",
                url: "{controller}/{action}/{type}"
            );

            routes.MapRoute(
                name: "Developer",
                url: "{controller}/{action}/{devName}"
            );

            routes.MapRoute(
                name: "Genre",
                url: "{controller}/{action}/{genre}"
            );

            routes.MapRoute(
                name: "Platform",
                url: "{controller}/{action}/{platName}"
            );

            routes.MapRoute(
                name: "Year",
                url: "{controller}/{action}/{releaseYear}"
            );

            routes.MapRoute(
                name: "Brand",
                url: "{controller}/{action}/{brand}"
            );
        }
    }
}
