using LayoutAndViews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutAndViews.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult CheckNumber()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CheckNumber(double input)
        {
            ViewBag.Result = NumberCheck.CheckNumber(input);

            return View();
        }
    }
}