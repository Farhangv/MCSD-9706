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
    }
}