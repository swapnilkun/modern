using ModernMarketResearch.Areas.Admin.Models.ViewModel;
using ModernMarketResearch.Models;
using ModernMarketResearch.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;

namespace ModernMarketResearch.Controllers
{
    public class NewsController : Controller
    {
        //
        // GET: /News/
        ModernMarketResearchEntities db = new ModernMarketResearchEntities();

        public ActionResult Index()
        {
            ViewBag.activemenu = "News";
            return View();
        }
        [OutputCache(Duration = 60, VaryByParam = "none")]
        public ActionResult LatestNews()
        {
            var latestnews = db.spLatestNews().ToList();
            return PartialView(latestnews);
        }
        public ActionResult LatestNewsForIndexPage()
        {
            var latestnews = db.spLatestNews().ToList();
            return PartialView(latestnews);
        }
        public ActionResult LatestNewsForReportDetails()
        {
            
            var latestnews = (from l in db.NewsMasters
                              join c in db.CategoryMasters on l.CategoryId equals c.CategoryId
                              orderby l.CreatedDate descending
                              select new NewsDetailsVM
                              {
                                  NewsId = l.NewsId,
                                  NewsTitle = l.NewsTitle,
                                  NewsURL = l.NewsUrl,
                                  NewsDetail = l.NewsDescription.Substring(0, 250),
                                  NewsPublishingDate = l.PublishingDate,
                                  CategoryName = c.CategoryName,
                                  CategoryUrl = c.CategoryUrl,
                                  CategoryId = c.CategoryId
                              }).Take(5).ToList();
            return PartialView(latestnews);
        }
        public ActionResult NewsDetails(string NewsUrl)
        {
            if (db.NewsMasters.Count(x => x.NewsUrl == NewsUrl) > 0)
            {

                var SelectedNewsdetails = (from l in db.spSelectedNewsDetails(NewsUrl)
                                           select new NewsDetailsVM
                                           {
                                               NewsDetail = l.NewsDescription,
                                               NewsTitle = l.NewsTitle,
                                               NewsPublishingDate = Convert.ToDateTime(l.PublishingDate),
                                               CategoryName = l.CategoryName,
                                               CategoryUrl = l.CategoryUrl,
                                               NewsImage=l.NewsImage
                                           }).FirstOrDefault();
                return View(SelectedNewsdetails);
            }
            else
            {
                return HttpNotFound();
            }

        }
        public ActionResult AllNews(int? pageno)
        {
            var x = (from n in db.NewsMasters
                     join c in db.CategoryMasters on n.CategoryId equals c.CategoryId
                     where n.IsActive == true
                     orderby n.CreatedDate descending
                     select new NewsVM
                     {
                         NewsId = n.NewsId,
                         NewsTitle = n.NewsTitle,
                         NewsDetail = n.NewsDescription.Substring(0, 300),
                         NewsPublishingDate = n.PublishingDate,
                         NewsURL = n.NewsUrl,
                         CategoryName = c.CategoryName,
                         CategoryUrl = c.CategoryUrl,
                         NewsImage=n.NewsImage
                     }).ToPagedList(pageno ?? 1, 10);
            ViewBag.activemenu = "News";
            return View(x);
        }

    }
}
