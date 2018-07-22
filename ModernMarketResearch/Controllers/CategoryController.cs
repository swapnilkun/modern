using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModernMarketResearch.Models;
namespace ModernMarketResearch.Controllers
{
    public class CategoryController : Controller
    {
        //
        // GET: /Category/
       CategoryDataRepository ObjCatrepository = new CategoryDataRepository();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MainCategories()
        {
            var maincat = ObjCatrepository.GetMainCategories();
            return View(maincat);
        }
    }
}
