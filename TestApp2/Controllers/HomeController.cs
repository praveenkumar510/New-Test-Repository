using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessAPI.BO;
using BusinessAPI.BL;

namespace TestApp2.Controllers
{
    public class HomeController : Controller
    {
        Employeedetails empdetails;
        public ActionResult Index1()
        {// This code is not from pulled code folder
//This is secondline.
//This is third line  this is commented..
            empdetails = new Employeedetails();
            return View(empdetails.GetEmpDetails());
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}