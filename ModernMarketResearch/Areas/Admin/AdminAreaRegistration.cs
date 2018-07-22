using System.Web.Mvc;

namespace ModernMarketResearch.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
                context.MapRoute("Admin_Report",
                   "Admin/AdminReport/ReportIndex/{id}",
               new { controller = "AdminReport", action = "ReportIndex", id = UrlParameter.Optional },
              namespaces: new[] { "ModernMarketResearch.Areas.Admin.Controllers" }
               );
            context.MapRoute(
                "Admin_default",
                 "Admin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "ModernMarketResearch.Areas.Admin.Controllers" }
            );
        }
    }
}
