using BSFramework.Models;
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
            UserModels m1 = new UserModels()
            {
                UserGUID = Guid.NewGuid().ToString(),
                UserName = "张一"
            };

            UserModels m2 = new UserModels()
            {
                UserGUID = Guid.NewGuid().ToString(),
                UserName = "张二"
            };

            UserModels m3 = new UserModels()
            {
                UserGUID = Guid.NewGuid().ToString(),
                UserName = "张三"
            };
            List<UserModels> UserList = new List<UserModels>();
            UserList.Add(m1);
            UserList.Add(m2);
            UserList.Add(m3);
            UserList.Add(m3);
            UserList.Add(m3);
            UserList.Add(m3);
            UserList.Add(m3);
            UserList.Add(m3);
            UserList.Add(m3);
            UserList.Add(m3);
            UserList.Add(m3);
            UserList.Add(m3);
            UserList.Add(m3);
            UserList.Add(m3);
            UserList.Add(m3);
            UserList.Add(m3);
            UserList.Add(m3);
            UserList.Add(m3);
            UserList.Add(m3);
            UserList.Add(m3);
            UserList.Add(m3);
            UserList.Add(m3);
            UserList.Add(m3);
            UserList.Add(m3);
            UserList.Add(m3);
            UserList.Add(m3);
            UserList.Add(m3);
            UserList.Add(m3);
            UserList.Add(m3);
            UserList.Add(m3);


            UserList.Add(m3);
            UserList.Add(m3);

            UserList.Add(m3);
            UserList.Add(m3);
            UserList.Add(m3);
            return Json(new { total = UserList.Count(), rows = UserList }, "text/html", Encoding.UTF8,

    JsonRequestBehavior.AllowGet);

        }
        public ActionResult UserManage()
        {
            return View();
        }

        //
        // GET: /SystemManage/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /SystemManage/Create
        public ActionResult Create()
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
        public ActionResult Edit(int id)
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
