using Casgem_Portfolio.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Casgem_Portfolio.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Users user)
        {
            CasgemPortfolioEntities1 db = new CasgemPortfolioEntities1();
            var user_ = db.Users.FirstOrDefault(x => x.Username == user.Username && x.Password == user.Password);
            if (user_ != null)
            {
                FormsAuthentication.SetAuthCookie(user_.Username, false);
                Session["username"] = user.Username.ToString();
                return RedirectToAction("Index", "About");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
    }
}