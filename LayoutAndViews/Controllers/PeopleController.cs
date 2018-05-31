using LayoutAndViews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutAndViews.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {

            return View(ListModel.ListOfPeople);
        }

       
        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Create(string name, string address, int age)
        {
            ListModel.ListOfPeople.Add(new Person { Name = name, Address = address, Age = age });

            return RedirectToAction("Index");
        }
    }
}