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
            List<AccordionModels> accordions = new List<AccordionModels>();
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
        public ActionResult AccordionManage()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public void AccordionCreate()
        {
           // var aa = form["acctitle"];

            if (Request.Form[" acctitle"] != null)
            {
                string title = Request.Form["acctitle"].ToString();
            }
          //  return View("AccordionAdd");
        }
        public ActionResult AccordionAdd()
        {

            
            return View();
        }

        public JsonResult AccordionManageData()
        {
            using (DataBaseContext context = new DataBaseContext())
            {
                try
                {
                    // accordions = context.AccordionContext.Include("Hrefs").ToList();

                    List<AccordionModels> AccordionModels = context.AccordionContext.Select(a => new
                    {
                        a.ID,
                        a.title,
                        a.icon

                    }).ToList()
                    .Select(b => new AccordionModels()
                    {
                        ID = b.ID,
                        title = b.title,
                        icon = b.icon
                    }).ToList();

                    return Json(new { total = AccordionModels.Count(), rows = AccordionModels }, "text/html", Encoding.UTF8,
            JsonRequestBehavior.AllowGet);
                }
                catch
                {
                    throw;
                }

            }
        }


        public JsonResult HrefManageData(string AccordionID)
        {
            string parentID = AccordionID ?? "626d6858-3fd2-417e-a6bb-8b16796d9a83";
            using (DataBaseContext context = new DataBaseContext())
            {
                try
                {
                    // accordions = context.AccordionContext.Include("Hrefs").ToList();

                    List<HrefModels> HrefModelsModels = context.HrefContext.Where(h => h.Accordion.ID == parentID).Select(a => new
                    {
                        a.ID,
                        a.title,
                        a.icon,
                        a.iFrame,
                        a.link,
                        a.Accordion

                    }).ToList()
                    .Select(b => new HrefModels()
                    {
                        ID = b.icon,
                        title = b.title,
                        icon = b.icon,
                        iFrame = b.iFrame,
                        link = b.link,
                        Accordion = new AccordionModels() { title = b.Accordion.title }
                    }).ToList();

                    return Json(new { total = HrefModelsModels.Count(), rows = HrefModelsModels }, "text/html", Encoding.UTF8,
            JsonRequestBehavior.AllowGet);
                }
                catch
                {
                    throw;
                }

            }
        }
    }
}