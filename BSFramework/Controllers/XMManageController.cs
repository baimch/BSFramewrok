using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BSFramework.Controllers
{
    public class XMManageController : Controller
    {
        //
        // GET: /XMManage/
        public ActionResult AdultPigList()
        {
            return View();
        }
        public ActionResult AdultPigCard()
        {
            return View();
        }
        public ActionResult PigletList()
        {
            return View();
        }
        public ActionResult PigletPigCard()
        {
            return View();
        }

	}
}