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

        [HttpPost]
        public string PostUsingParameters (string firstname , string lastname)
        {
            return "From Parameters - " + firstname + " " + lastname;
        }

        [HttpPost]
        public string PostUsingRequest()
        {
            string firstname = Request["firstname"];
            string lastname = Request["lastname"];
            return "From Request - " + firstname + " " + lastname;
        }


        [HttpPost]
        public string PostUsingFormCollection(FormCollection form)
        {
            string firstname = form["firstname"];
            string lastname =  form["lastname"];
            return "From Form Collection - " + firstname + " " + lastname;
        }


        //Now Using Strongly Binding. For this WeakReference need a model.
       
        
        [HttpPost]
        public string PostUsingBinding(Employee emp)
        {
           
            return "From Binding - " + emp.firstname + " " + emp.lastname;
        }

    }
}