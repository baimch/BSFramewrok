using BSFramework.Models;
using DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace BSFramework.Controllers
{
    public class SystemManageController : Controller
    {
        //
        // GET: /SystemManage/
        public JsonResult UserManageData()
        {

            using (DataBaseContext context = new DataBaseContext())
            {               
                var UserList = context.UserContext.Select(
                    m => new UserModelsView
                    {
                        UserGUID = m.UserGUID,
                        UserName = m.UserName,
                        UserBirthDay = m.UserBirthDay,
                        UserMail = m.UserMail,
                        UserNumber = m.UserNumber,
                        UserPhone = m.UserPhone
                    }).ToList();
            
            return Json(new { total = UserList.Count(), rows = UserList }, "text/html", Encoding.UTF8,
                JsonRequestBehavior.AllowGet);
            }

        }
        public ActionResult UserManage()
        {
            return View();
        }

        //
        // GET: /SystemManage/Details/5
        public ActionResult YZCReview()
        {
            return View();
        }

        //
        // GET: /SystemManage/Create
        public ActionResult UserCreate()
        {
            return View();
        }

        //
        // POST: /SystemManage/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /SystemManage/Edit/5
        public ActionResult Regist()
        {
            return View();
        }

        //
        // POST: /SystemManage/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /SystemManage/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /SystemManage/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
