using ModernMarketResearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModernMarketResearch.Controllers
{
    public class SitemapController : Controller
    {
        //
        // GET: /Sitemap/

        Sitemap report = new ModernMarketResearch.Models.Sitemap();

        public ActionResult Index()
        {
            var SitemapReportUrl = report.GenerateIndex();
            Response.ContentType = "text/xml";
            Response.Write(SitemapReportUrl);
            Response.End();
            return Content(SitemapReportUrl);
        }

        public ActionResult SiteMapReports(int PageNo)
        {
            var SitemapReportUrl = report.SiteMapReports(PageNo);
            Response.ContentType = "text/xml";
            Response.Write(SitemapReportUrl);
            Response.End();
            return Content(SitemapReportUrl);
        }

    }
}
