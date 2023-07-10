using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Casgem_Portfolio.Models.Entities;

namespace Casgem_Portfolio.Controllers
{
    public class ServiceController : Controller
    {

        CasgemPortfolioEntities1 db = new CasgemPortfolioEntities1();
        public ActionResult Index()
        {
            var values = db.tbl_service.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddService()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddService(tbl_service p)
        {
            db.tbl_service.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteService(int id)
        {
            var value = db.tbl_service.Find(id);
            db.tbl_service.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateService(int id)
        {
            var value = db.tbl_service.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateService(tbl_service p)
        {
            var value = db.tbl_service.Find(p.ServiceID);
            value.ServiceTitle = p.ServiceTitle;
            value.ServiceIcon = p.ServiceIcon;
            value.ServiceNumber = p.ServiceNumber;
            value.ServiceContent = p.ServiceContent;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}