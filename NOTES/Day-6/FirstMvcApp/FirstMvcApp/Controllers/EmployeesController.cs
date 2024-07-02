using FirstMvcApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMvcApp.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly List<Employee> employees;

        public EmployeesController()
        {
            employees = new List<Employee>()
            {
                new Employee(){EmployeeId=2378,EmployeeName="Pravinkumar R. D.",City="Pune"},
                new Employee(){EmployeeId=2379,EmployeeName="Alisha C.",City="Mumbai"},
                new Employee(){EmployeeId=2380,EmployeeName="Manish Kaushik",City="Raipur"}
            };
        }

        public ActionResult Index()
        {
            //return File("~/Content/Site.css","text/css");
            return Content("Default Action method of Employees Controller");
        }
        public ActionResult Data()
        {
            return Json(employees, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Office()
        {
            return View("InfoOffice");
        }
        public ActionResult List()
        {
            return View(employees);
        }
    }
}