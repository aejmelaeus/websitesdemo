using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSitesDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.ConfigText = ConfigurationManager.AppSettings["AppSetting"];
            return View();
        }

        public ActionResult About()
        {
            Trace.TraceInformation("Något spännande!");

            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            Trace.TraceError("Något katastrofalt!");

            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}