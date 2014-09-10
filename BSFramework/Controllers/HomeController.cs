using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BSFramework.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public void  Index(string aa)
        {

            Response.Redirect("/home/framework");

        }
        public ActionResult Framework()
        {
            return View();
        }
        
        public ActionResult HomePage()
        {
           

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Regist()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}