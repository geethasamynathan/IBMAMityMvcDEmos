using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FiltersDemo.Controllers
{
    public class HomeController : Controller
    {
        [HandleError]
        public ActionResult Index()
        {
          //  throw new Exception("Something went wrong");
            return View();
        }

        public ActionResult About()
        {
          
           // ViewBag.Message = "Your application description page.";
           // return View();
            throw new Exception("Something went wrong");
           
        }

        public ActionResult Contact()
        {
           
            ViewBag.Message = "Your contact page.";

            return View();
            throw new Exception("Something went wrong");
        }
    }
}