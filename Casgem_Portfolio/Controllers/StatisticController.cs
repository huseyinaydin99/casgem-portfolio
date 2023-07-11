using Casgem_Portfolio.Models.Entities;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Casgem_Portfolio.Controllers
{
    public class StatisticController : Controller
    {

        CasgemPortfolioEntities1 db = new CasgemPortfolioEntities1();
        
        public ActionResult Index()
        {
            ViewBag.employeeCount = db.TblEmployee.Count();
            var salary = db.TblEmployee.Max(x => x.EmployeeSalary);
            ViewBag.maxSalaryEmployee = db.TblEmployee.Where(x => x.EmployeeSalary == salary).Select(y => y.EmployeeName + " " + y.EmployeeSurname).FirstOrDefault();
            Console.WriteLine(ViewBag.maxSalaryEmployee);

            ViewBag.totalCityCount = db.TblEmployee.Select(x => x.EmployeeCity).Distinct().Count();

            ViewBag.avgEmployeeSalary = db.TblEmployee.Average(x => x.EmployeeSalary);
            ViewBag.countSoftwareDepartment = db.TblEmployee.Where(x => x.EmployeeDepartment == db.TblDepartment.Where(z => z.DepartmentName == "Yazılım").Select(y => y.DepartmentID).FirstOrDefault()).Count();
            //Şehri Ankara veya Adana olanların toplam maaşı
            ViewBag.sumTotalSalary = db.TblEmployee.Where(x => x.EmployeeCity == "Ankara" || x.EmployeeCity == "Adana").Sum(x => x.EmployeeSalary);
            ViewBag.sumSalaryFromSoftwareDepartment = db.TblEmployee.Where(x => x.EmployeeCity == "Ankara" && x.EmployeeDepartment == db.TblDepartment.Where(z => z.DepartmentName == "Yazılım").Select(y => y.DepartmentID).FirstOrDefault()).Sum(w => w.EmployeeSalary);
            return View();
        }
    }
}