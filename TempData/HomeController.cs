using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewBagViewData.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            TempData["MyKey"] = "Data from index metod";
            return View();
        }

        public ActionResult Index2()
        {
            //ViewBag.MyKey = TempData("MyKey");
            //TempData.Keep("MyKey");
            //return View();

            ViewBag.MyKey = TempData.Peek("MyKey");
           
            return View();
        }

        public ActionResult Index3()
        {
            ViewBag.MyKey = TempData["MyKey"];
            return View();
        }
    }
}