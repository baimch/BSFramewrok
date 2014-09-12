using BSF.Core.Models.Account;
using BSF.Site;
using BSF.Site.Models;
using BSF.Tools;
using BSFramework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace BSFramework.Controllers
{
    [Export]
    public class SystemManageController : Controller
    {
        [Import]
        public IAccountSiteContract AccountContract { get; set; }
        //
       
        public JsonResult UserManageData(int? page,int? rows)
        {
            int mpage = page ?? 1;
             int pageSize = rows??10;
            PropertySortCondition[] sortConditions = new[] { new PropertySortCondition("Id") };
            int total;
            var memberViews = AccountContract.Members.Where<Member, int>(m => true, mpage, pageSize, out total, sortConditions).Select(m => new MemberView
            {
                UserName = m.UserName,
                NickName = m.NickName,
                Email = m.Email,
                IsDeleted = m.IsDeleted,
                AddDate =m.AddDate,
                LoginLogCount = m.LoginLogs.Count,
                RoleNames = m.Roles.Select(n => n.Name)
            });
            //  PagedList<MemberView> model = new PagedList<MemberView>(memberViews, pageIndex, pageSize, total);
            // return View(model);         
            return Json(new { total = total, rows = memberViews }, "text/html", Encoding.UTF8,
                JsonRequestBehavior.AllowGet);

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
