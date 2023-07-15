using Casgem_Portfolio.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_Portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        CasgemPortfolioEntities1 db = new CasgemPortfolioEntities1();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RedirectToPortfolioIndex()
        {
            ViewBag.parameters = "Mesaj Gonderildi";
            return View("Index");
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialFeature()
        {
            ViewBag.featureTitle = db.tbl_feature.Select(x => x.FeatureTitle).FirstOrDefault();
            ViewBag.featureDescription = db.tbl_feature.Select(x => x.FeatureDescription).FirstOrDefault();
            ViewBag.featureImage = db.tbl_feature.Select(x => x.FeatureImage).FirstOrDefault();
            return PartialView();
        }

        public PartialViewResult MyResume()
        {
            var values = db.tbl_resume.ToList();   
            return PartialView(values);
        }

        public PartialViewResult PartialStatistic()
        {
            ViewBag.totalService = db.tbl_service.Count();
            ViewBag.totalMessage = db.tbl_message.Count();
            ViewBag.totalThanksMessage = db.tbl_message.Where(x => x.MessageSubject == "Teşekkür").Count();
            
            return PartialView();
        }

        //Portofolio/test
        [HttpGet]
        public string test()
        {
            return "selam";
        }

        [HttpGet]
        public FileResult Download()
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(this.Server.MapPath("\\Data\\CV_HUSEYIN_AYDIN_DEFAULT.pdf"));
            string fileName = "CV_HUSEYIN_AYDIN_DEFAULT.pdf";
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }
    }
}