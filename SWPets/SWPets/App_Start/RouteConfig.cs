using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SWPets
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional });

            routes.MapRoute(
                name: "Pets",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Pets", id = UrlParameter.Optional });

            routes.MapRoute(
                name: "Adotantes",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Adotantes", id = UrlParameter.Optional });

            routes.MapRoute(
                name: "Estoque",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Estoque", id = UrlParameter.Optional });

            routes.MapRoute(
               name: "Ajuda",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Ajuda", id = UrlParameter.Optional });
        }
    }
}
