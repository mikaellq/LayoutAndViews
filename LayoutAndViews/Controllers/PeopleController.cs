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
            List<Person> listOfPeople = new List<Person>();
            Person p1 = new Person();
            Person p2 = new Person();
            Person p3 = new Person();
            p1.Name = "Kalle";
            p1.Age = 25;
            p1.Address = "Vägen 12";

            p2.Name = "Anna";
            p2.Age = 32;
            p2.Address = "Gatan 13";

            p3.Name = "Anders";
            p3.Age = 25;
            p3.Address = "Stigen 3";

            listOfPeople.Add(p1);
            listOfPeople.Add(p2);
            listOfPeople.Add(p3);

            return View(listOfPeople);
        }

    }
}