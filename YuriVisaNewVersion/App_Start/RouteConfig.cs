using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace YuriVisaNewVersion
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
            name: "NewView",
            url: "{controller}/{action}/{Metatitle}",
            defaults: new { controller = "Home", action = "NewView" },
            namespaces: new[] { "YuriVisaNewVersion.Controllers" }
        );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "YuriVisaNewVersion.Controllers" }
            );
          
        }
    }
}
