using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            var modelx = new AboutModel();

            modelx.Name = "Yibin Pan";

            modelx.Location = "Beijing";

            modelx.School = "BUPT";

            ViewBag.Locationx = "USA";

            return View(modelx);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}