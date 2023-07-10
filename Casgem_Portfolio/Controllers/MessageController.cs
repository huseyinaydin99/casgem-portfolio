using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Casgem_Portfolio.Models.Entities;

namespace Casgem_Portfolio.Controllers
{
    public class MessageController : Controller
    {
        CasgemPortfolioEntities1 db = new CasgemPortfolioEntities1();
        public ActionResult Index()
        {
            var values = db.tbl_message.ToList();
            return View(values);
        }
        public ActionResult DeleteMessage(int id)
        {
            var value = db.tbl_message.Find(id);
            db.tbl_message.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult MessageDetails(int id)
        {
            var value = db.tbl_message.Find(id);
            return View(value);
        }
    }
}