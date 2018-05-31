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
            ListModel.ListOfPeople.Add(new Person { Name = "Krall", Age = 30, Address = "Storgatan 23" });
            ListModel.ListOfPeople.Add(new Person { Name = "Jonathan", Age = 33, Address = "Gatan 5" });
            ListModel.ListOfPeople.Add(new Person { Name = "Linus", Age = 44, Address = "Vägen 7" });

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