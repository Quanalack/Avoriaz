using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AvoriazWeb.Controllers
{
    public class ThailandController : Controller
    {
        // GET: Thailand
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Gallery()
        {
            ViewBag.Message = "A gallery of the pictures taken in Thailand.";

            return View();
        }
    }
}