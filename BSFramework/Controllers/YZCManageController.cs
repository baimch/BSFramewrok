using BSFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace BSFramework.Controllers
{
    public class YZCManageController : Controller
    {
        //
        // GET: /YZCManage/
        //棚舍管理
        public ActionResult Barracks()
        {
            return View();
        }
        public JsonResult BarracksData()
        {
            BarrackModels m1 = new BarrackModels()
            {
                BarrackGUID = Guid.NewGuid().ToString(),
                BarrackName = "屋舍一",
                BarrackNumber = "0001",
                BarrackPrice = "3000",
                BarrackArea = "100平米",
                Barrackbirth = "2010年9月",
                Barrackcapacity = "20",
                company = new CompanyModels() { CompanyGUID = "aaa", CompanyName = "sdsdsdsd" }
            };
            BarrackModels m2 = new BarrackModels()
            {
                BarrackGUID = Guid.NewGuid().ToString(),
                BarrackName = "屋舍二",
                BarrackNumber = "0002",
                BarrackPrice = "3000",
                BarrackArea = "100平米",
                Barrackbirth = "2010年9月",
                Barrackcapacity = "20"
            };
            List<BarrackModels> BarrackList = new List<BarrackModels>();
            BarrackList.Add(m1);
            BarrackList.Add(m2);
            return Json(new { total = BarrackList.Count(), rows = BarrackList }, "text/html", Encoding.UTF8,
                JsonRequestBehavior.AllowGet);
        }

        public ActionResult JUAN()
        {
            return View();
        }

        public ActionResult BarracksCreate()
        {
            return View();
        }
    }
}