using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class DemoController : Controller
    {
        public ActionResult Sample()
        {
            //return Content("سلام");
            //return View();
            //Person p = new Person() { Name = "رضا", Family = "رضایی" };
            //return View(p);
            //return new ContentResult() { Content = "سلام", ContentEncoding = Encoding.UTF8, ContentType = "plain/text" };
            return new EmptyResult();
        }

        public ActionResult ViewDemo()
        {
            //return View("~/Views/MyFolder/MyView.cshtml");
            return View();
        }

        public ActionResult ViewDataDemo()
        {
            ViewData["Names"] = new List<string>() { "C#", "Java", "PHP", "Python" };
            return View();
        }

        public ActionResult ViewBagDemo()
        {
            ViewBag.Names = new List<string>() { "C#", "Java", "PHP", "Python" };
            return View();
        }

        public ActionResult ModelDemo()
        {
            ViewBag.MessageClass = "warning";
            ViewBag.Message = "لیست دوره های پاییز ۹۷";
            var courses = new List<Course>()
            {
                new Course() { Title = "سی شارپ", Duration = 40 },
                new Course() { Title = "لاراول", Duration = 110 },
                new Course() { Title = "SQL", Duration = 50 },
                new Course() { Title = "برنامه نویسی کلایت ساید", Duration = 30 },
                new Course() { Title = "جاوا", Duration = 70 }
            };
            return View(courses);
        }
    }
}