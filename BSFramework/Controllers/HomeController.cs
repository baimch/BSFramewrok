using BSFramework.Models;
using DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DatabaseModels;
using System.Text;

namespace BSFramework.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<AccordionModels> accordions =new List<AccordionModels>();
            using (DataBaseContext context = new DataBaseContext())
            {
                try
                {
                    accordions = context.AccordionContext.Include("Hrefs").ToList();
                   
                    //accordions = context.AccordionContext.Select(a => new AccordionModels()
                    //{
                    //    ID = a.ID,
                    //    title = a.title,
                    //    icon = a.icon

                    //}).ToList();
                }
                catch (Exception e) { }
              
            }

            JsonResult jr = Json(new { total = accordions.Count(), rows = accordions }, "text/html", Encoding.UTF8,
           JsonRequestBehavior.AllowGet);
          
            //return jr;
            return View(accordions);
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
        public ActionResult Framework()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}