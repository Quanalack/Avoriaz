using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace AvoriazWeb.Controllers
{
    public class AvoriazController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "The map of Avoriaz:";

            return View();
        }

        public ActionResult EachDay()
        {
            return View();
        }

        
    }
}