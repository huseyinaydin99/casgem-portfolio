using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Casgem_Portfolio.Models.Entities;

namespace Casgem_Portfolio.Controllers
{
    public class ContactController : Controller
    {
        CasgemPortfolioEntities1 db = new CasgemPortfolioEntities1();

        // GET: Contact
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(tbl_message p)
        {
            db.tbl_message.Add(p);
            db.SaveChanges();


            return RedirectToAction("RedirectToPortfolioIndex", "Portfolio");

            //return View("Index", "Portfolio", "message_added");
            //return View("Index", "message_added");
            //return RedirectToAction("Index", "Portfolio");
        }

        [HttpPost]
        public void SaveMessage(FormCollection fc)
        {
            var Name_Surname = fc[0].ToString(); //user
            var SenderMail = fc[1].ToString();
            var MessageSubject = fc[2].ToString();
            var Content = fc[3].ToString();
            tbl_message tbl_Message = new tbl_message
            {
                Name_Surname = Name_Surname,
                SenderMail = SenderMail,
                MessageSubject = MessageSubject,
                Content = Content
            };
            db.tbl_message.Add(tbl_Message);
            db.SaveChanges();


            //return RedirectToAction("RedirectToPortfolioIndex", "Portfolio");

            //return View("Index", "Portfolio", "message_added");
            //return View("Index", "message_added");
            //return RedirectToAction("Index", "Portfolio");
        }
    }
}