using Casgem_Portfolio.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Casgem_Portfolio.Models.Entities;

namespace Casgem_Portfolio.Controllers
{
    public class ProjectController : Controller
    {
        CasgemPortfolioEntities1 db = new CasgemPortfolioEntities1();
        public ActionResult Index()
        {
            var values = db.tbl_projects.ToList();
            return View(values);
        }

        public ActionResult DeleteProject(int id)
        {
            var value = db.tbl_projects.Find(id);
            db.tbl_projects.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult ProjectDetails(int id)
        {
            var value = db.tbl_projects.Find(id);
            return View(value);
        }

        [HttpGet]
        public ActionResult UpdateProject(int id)
        {
            var value = db.tbl_projects.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateProject(tbl_projects p)
        {
            var value = db.tbl_projects.Find(p.ProjectID);
            value.Description = p.Description;
            value.Purpose = p.Purpose;
            value.Name_ = p.Name_;
            value.ProjectID = p.ProjectID;
            value.ProjectType = p.ProjectType;
            db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}