﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ModernMarketResearch
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
           name: "CategoryRelatedReports",
           url: "category/{caturl}",
           defaults: new { controller = "Report", action = "CategoryRelatedReports", caturl = UrlParameter.Optional },
           namespaces: new[] { "ModernMarketResearch.Controllers" }
           );

            routes.MapRoute(
              name: "AllLatestReport",
              url: "latest/reports/",
              defaults: new { controller = "Report", action = "AllReports" },
              namespaces: new[] { "ModernMarketResearch.Controllers" }
           );
           
            routes.MapRoute(
               name: "LatestReport",
               url: "latest-report/",
               defaults: new { controller = "Report", action = "LatestReport" },
               namespaces: new[] { "ModernMarketResearch.Controllers" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "ModernMarketResearch.Controllers" }
            );
        }
    }
}