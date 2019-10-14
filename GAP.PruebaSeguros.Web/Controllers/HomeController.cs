using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GAP.PruebaSeguros.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult GetInsurance()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult CreateInsurance()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult UpdateInsurance()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult DeleteInsurance()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
