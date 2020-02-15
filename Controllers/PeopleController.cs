using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListPeople()
        {
            List<PersonModel> people = new List<PersonModel>();

            people.Add(new PersonModel { FirstName = "David", LastName = "Mortin", Age = 30 });
            people.Add(new PersonModel { FirstName = "John", LastName = "Doe", Age = 35 });
            people.Add(new PersonModel { FirstName = "Sarah", LastName = "Andreson", Age = 28 });

            return View(people);
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}