using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebControlNie.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "家居监控Web控制端";

            return View();
        }

        public ActionResult Security()
        {
            ViewBag.Message = "安防";

            return View();
        }

        public ActionResult Light()
        {
            ViewBag.Message = "照明";

            return View();
        }

        public ActionResult Swith()
        {
            ViewBag.Message = "开关";

            return View();
        }
    }
}
