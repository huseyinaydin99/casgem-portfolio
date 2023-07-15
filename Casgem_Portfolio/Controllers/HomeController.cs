using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_Portfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Index","Portfolio");
        }

        public ActionResult About()
        {
            return RedirectToAction("Index", "Portfolio");
        }

        public ActionResult Contact()
        {
            return RedirectToAction("Index", "Portfolio");
        }
    }
}