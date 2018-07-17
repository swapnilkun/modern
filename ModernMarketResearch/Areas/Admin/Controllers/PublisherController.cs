using ModernMarketResearch.Areas.Admin.Models.DAL;
using ModernMarketResearch.Areas.Admin.Models.ViewModel;
using ModernMarketResearch.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace ModernMarketResearch.Areas.Admin.Controllers
{
    public class PublisherController : Controller
    {
        //
        // GET: /Admin/Publisher/
        public ActionResult Index()
        {
            return View();
        }
        private PublisherRepository _ObjPublisherRepository;
        public PublisherController()
        {
            _ObjPublisherRepository = new PublisherRepository();
        }

        //[CustomAuthorization("ReportUploader,ReportCreater", "Create,Delete")]
        public ActionResult PublisherIndex()
        {
            // var publisher = db.PublisherMasters.ToList();

            return View(_ObjPublisherRepository.GetPublisher());
        }

        [HttpGet]
        //[CustomAuthorization("ReportUploader,ReportCreater", "Create,Delete")]
        public ActionResult PublisherCreate()
        {
            return View();
        }

        [HttpPost]
        //[CustomAuthorization("ReportUploader,ReportCreater", "Create,Delete")]
        public ActionResult PublisherCreate(PublisherVM pub)
        {
            _ObjPublisherRepository.InsertPublisher(pub);
            return RedirectToAction("PublisherIndex");
        }

        [HttpGet]
        //[CustomAuthorization("ReportUploader,ReportCreater", "Create,Delete")]
        public ActionResult PublisherEdit(int id)
        {
            return View(_ObjPublisherRepository.GetById(id));
        }
        // [CustomAuthorization("ReportUploader,ReportCreater", "Create,Delete")]
        public ActionResult PublisherEdit(PublisherVM pub)
        {
            _ObjPublisherRepository.PublisherEdit(pub);
            return RedirectToAction("PublisherIndex");
        }
        //[CustomAuthorization("ReportUploader,ReportCreater", "Create,Delete")]
        public ActionResult PublisherDetails(int id)
        {
            return View(_ObjPublisherRepository.GetById(id));
        }

        public ActionResult PublisherDelete(int id)
        {
            return View(_ObjPublisherRepository.GetById(id));
        }
        [ActionName("PublisherDelete")]
        public ActionResult PublisherDelete1(int id)
        {
            _ObjPublisherRepository.DeletePublisher(id);
            return RedirectToAction("PublisherIndex"); 
        }
    }
}
