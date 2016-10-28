﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _0002_RotasMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("CustomRoute2", "filtro/{cor}/{categoria}",
                            new { controller = "Produto", action = "Filtro" });

            routes.MapRoute("CustomRoute1",
                            "produto/{id}",
                            new { controller = "Produto", action = "Details" }
                            , new { id = "[0-9]+" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}