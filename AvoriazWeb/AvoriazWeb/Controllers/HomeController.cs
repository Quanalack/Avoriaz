﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AvoriazWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Map()
        {
            ViewBag.Message = "The map OLD  of Avoriaz:";

            return View();
        }

        public ActionResult Gallery()
        {
            ViewBag.Message = "A gallery of the pictures taken at Avoriaz.";

            return View();
        }
    }
}