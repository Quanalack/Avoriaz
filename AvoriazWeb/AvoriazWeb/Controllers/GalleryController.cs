using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AvoriazWeb.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Avoriaz()
        {
            ViewBag.Message = "A gallery of the pictures taken at Avoriaz.";

            String path = Server.MapPath("/Content/Images/Avoriaz/");
            String[] imagefiles = Directory.GetFiles(path);

            ViewBag.imageArray = imagefiles;

            return View();
        }

        public ActionResult Thailand()
        {
            ViewBag.Message = "A gallery of the pictures taken in Thailand.";

            String path = Server.MapPath("/Content/Images/Thailand/");
            String[] imagefiles = Directory.GetFiles(path);

            ViewBag.imageArray = imagefiles;

            return View();
        }

        public ActionResult Denmark()
        {
            ViewBag.Message = "A gallery of the pictures taken in Denmark.";

            String path = Server.MapPath("/Content/Images/Denmark/");
            String[] imagefiles = Directory.GetFiles(path);

            ViewBag.imageArray = imagefiles;

            return View();
        }
    }
}