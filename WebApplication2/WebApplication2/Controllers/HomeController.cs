using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            ViewBag.Message = "Cambio de finitivo";
            ViewBag.Message = "AGREGO MAS CAMBIOS";
            ViewBag.Message = "BLA BLA BLA BLA";
            ViewBag.Message = "BLA BLA BLA BLA";

            return View();
        }
    }
}