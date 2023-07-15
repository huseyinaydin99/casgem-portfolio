using Casgem_Portfolio.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_Portfolio.Controllers
{
    public class AboutController : Controller
    {
        CasgemPortfolioEntities1 db = new CasgemPortfolioEntities1();
        [HttpGet]
        public ActionResult Index()
        {
            var value = db.About.FirstOrDefault();
            return View(value);
        }

    }
}