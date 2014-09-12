using BSF.Core.Models.Account;
using BSF.Site;
using BSF.Site.Models;
using BSF.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BSFramework.Controllers
{
  [Export]
    public class HomeController : Controller
    {
        [Import]
        public IAccountSiteContract AccountContract { get; set; }
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult  Index(string aa)
        {

            //Response.Redirect("/home/framework");
            return RedirectToAction("framework", "Home");
        }
        public ActionResult Framework()
        {
            //int pageIndex = id ?? 1;
          
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