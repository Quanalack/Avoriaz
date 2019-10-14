using System;
using System.Collections.Generic;
using System.IO;
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

            String path = Server.MapPath("/Content/Images/Thailand/");
            String[] imagefiles = Directory.GetFiles(path);

            ViewBag.imageArray = imagefiles;

            return View();
        }
    }
}