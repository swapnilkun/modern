﻿using ModernMarketResearch.Areas.Admin.Models.ViewModel;
using ModernMarketResearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModernMarketResearch.Controllers
{
    public class HomeController : Controller
    {

        ReportVM r = new ReportVM();


        ModernMarketResearchEntities db = new ModernMarketResearchEntities();
        [OutputCache(Duration = 60, VaryByParam = "none")]
        public ActionResult Index()
        {

            ViewBag.ChemicalsMaterials = (from l in db.CategoryMasters
                                          join r in db.ReportMasters on l.CategoryId equals r.CategoryId
                                          //where l.CategoryName == "Chemicals & Materials"
                                          where l.CategoryId == 10 || l.ParentCategoryId == 10
                                          orderby r.CreatedDate descending
                                          select new ReportVM
                                          {
                                              ReportTitle = r.ReportTitle,
                                              ReportUrl = r.ReportUrl,
                                              FullDescription=r.LongDescritpion.Substring(0,150)

            ViewBag.TechnologyMedia = (from l in db.CategoryMasters
                                            join r in db.ReportMasters on l.CategoryId equals r.CategoryId
                                            //where l.CategoryName == "Electrical & Electronic"
                                            where l.CategoryId == 8 || l.ParentCategoryId == 8
                                            orderby r.CreatedDate descending
                                            select new ReportVM
                                            {
                                                ReportTitle = r.ReportTitle,
                                                ReportUrl = r.ReportUrl,
                                                FullDescription = r.LongDescritpion.Substring(0, 150)
                                            }).Take(3).ToList();

            ViewBag.ICTMedia = (from l in db.CategoryMasters
                                join r in db.ReportMasters on l.CategoryId equals r.CategoryId
                                //where l.CategoryName == "ICT and Media"
                                where l.CategoryId == 755 || l.ParentCategoryId == 755
                                orderby r.CreatedDate descending
                                select new ReportVM
                                {
                                    ReportTitle = r.ReportTitle,
                                    ReportUrl = r.ReportUrl,
                                    FullDescription = r.LongDescritpion.Substring(0, 150)
                                }).Take(3).ToList();

            ViewBag.HealthCares = (from l in db.CategoryMasters
                                     join r in db.ReportMasters on l.CategoryId equals r.CategoryId
                                     //where l.CategoryName == "Medical & Health"
                                     where l.CategoryId == 4 || l.ParentCategoryId == 4
                                     orderby r.CreatedDate descending
                                     select new ReportVM
                                     {
                                         ReportTitle = r.ReportTitle,
                                         ReportUrl = r.ReportUrl,
                                         FullDescription = r.LongDescritpion.Substring(0, 150)
                                     }).Take(3).ToList();

            ViewBag.ParentCategory = db.CategoryMasters.Where(x => x.ParentCategoryId == 0).ToList();
            ViewBag.Title = "Modern Market Research  - Market Research Reports, Industry Analysis, Trends and Forecast";
            ViewBag.Description = "Modern Market Research  provides in-depth and reliable market data, size, applications, industry structure, forecasts, related to Global and Chinese markets";
            return View();
        }

        [HttpGet]
        public ActionResult SearchingPartialView()
        {
            return PartialView(r);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
