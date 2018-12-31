using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SessionCookieDemo.Controllers
{
    public class SessionDemoController : Controller
    {
        // GET: SessionDemo
        public ActionResult Index()
        {
            if(Session["Counter"] == null)
                Session["Counter"] = 0;

            Session["Counter"] = ((int)Session["Counter"]) + 1;
            ViewBag.Counter = Session["Counter"];
            return View();
        }
    }
}