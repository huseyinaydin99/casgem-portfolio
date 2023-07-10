using Casgem_Portfolio.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_Portfolio.Controllers
{
    public class ReferenceController : Controller
    {
        CasgemPortfolioEntities1 db = new CasgemPortfolioEntities1();
        public ActionResult Index()
        {
            var values = db.tbl_referance.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddReference()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddReference(tbl_referance p)
        {
            db.tbl_referance.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteReference(int id)
        {
            var value = db.tbl_referance.Find(id);
            db.tbl_referance.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult ReferenceDetails(int id)
        {
            var value = db.tbl_referance.Find(id);
            return View(value);
        }

        [HttpGet]
        public ActionResult UpdateReference(int id)
        {
            var value = db.tbl_referance.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateReference(tbl_referance p)
        {
            var value = db.tbl_referance.Find(p.ReferanceID);
            value.NameSurname = p.NameSurname;
            value.PhoneNumber = p.PhoneNumber;
            value.ReferanceID = p.ReferanceID;
            value.Email = p.Email;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}