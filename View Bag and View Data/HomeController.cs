using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewBagViewData.Models;

namespace ViewBagViewData.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.MyCustomProp = "PAKISTAN";

            ViewBag.mylist = new List<string>() {"JON","MARK","KIM","JOE","ROCK"};

            List<Employee> emplist = new List<Employee>()
            {
                new Employee(){Email = "jkkjfk", id = 1, Name = "jldkfjkdl"},
                new Employee(){Email = "jkkjfk", id = 2, Name = "jldkfjkdl"},
                new Employee(){Email = "jkkjfk", id = 3, Name = "jldkfjkdl"},
            };

            ViewBag.myemplist = emplist;
            return View();
        }
    
    public ActionResult Dviewdata()
        {
            ViewData["MyKey"] = "Tis is my key";
            return View();
        }
    
    }
}