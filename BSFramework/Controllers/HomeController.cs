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
        public void  Index(string aa)
        {

            Response.Redirect("/home/framework");

        }
        public ActionResult Framework()
        {
            //int pageIndex = id ?? 1;
            const int pageSize = 20;
            PropertySortCondition[] sortConditions = new[] { new PropertySortCondition("Id") };
            int total;
            var memberViews = AccountContract.Members.Where<Member, int>(m => true, 1, pageSize, out total, sortConditions).Select(m => new MemberView
            {
                UserName = m.UserName,
                NickName = m.NickName,
                Email = m.Email,
                IsDeleted = m.IsDeleted,
                AddDate = m.AddDate,
                LoginLogCount = m.LoginLogs.Count,
                RoleNames = m.Roles.Select(n => n.Name)
            });
          //  PagedList<MemberView> model = new PagedList<MemberView>(memberViews, pageIndex, pageSize, total);
           // return View(model);
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