using MVCDemo.Models;
using MVCDemo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class PeopleController : Controller
    {
        public ActionResult Index()
        {
            var peopleRepository = new PeopleRepository();
            return View(peopleRepository.GetAllPeople());
        }

        public ActionResult Create()//نمایش فرم ثبت کاربر
        {
            return View();
        }

        //public ActionResult Store() //(1)
        [HttpPost]
        //public ActionResult Create(FormCollection form) //(2)
        //public ActionResult Create(string name, string family, int age) //(3)
        public ActionResult Create(Person person) //(4)
        {
            var peopleRepository = new PeopleRepository();

            ////(1)
            //Person person = new Person();
            //person.Name = Request["Name"];
            //person.Family = Request["Family"];
            //person.Age = int.Parse(Request["Age"]);

            ////(2)
            //Person person = new Person();
            //person.Name = form["Name"];
            //person.Family = form["Family"];
            //person.Age = int.Parse(form["Age"]);

            //(3)
            //Person person = new Person();
            //person.Name = name;
            //person.Family = family;
            //person.Age = age;

            if (peopleRepository.AddPerson(person))
            {
                return Content($"{person.Name} {person.Family} با موفقیت درج شد");
            }

            return Content("خطا در درج کاربر");
        }
    }
}