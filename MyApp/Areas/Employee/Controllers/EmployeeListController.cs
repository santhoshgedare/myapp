using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyApp.Areas.Employee.Controllers
{
    public class EmployeeListController : Controller
    {
        // GET: Employee/EmployeeList
        public ActionResult Index()
        {
            return View();
        }
    }
}