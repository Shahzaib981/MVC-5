using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewToController.Models;

namespace ViewToController.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        


        //Now Using Strongly Binding. For this We need a model.
       
        
        [HttpPost]
        public ActionResult Submitdata(Employee emp)
        {
           if (ModelState.IsValid)
            {
                return View();
            }
            return View("Index");
        }

    }
}