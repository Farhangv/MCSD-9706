using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SessionCookieDemo.Controllers
{
    public class CookieDemoController : Controller
    {
        public ActionResult Index()
        {
            var counterCookie = Request.Cookies.Get("Counter");
            if (counterCookie == null)//اگر کوکی به نام کانتر در درخواست وجود نداشت
            {
                counterCookie = new HttpCookie("Counter");
                counterCookie.Value = 0.ToString();
                counterCookie.Expires = DateTime.Now.AddYears(2);
                
                //counterCookie.Values.Add("Username", "Kahkeshan");
            }
            counterCookie.Value = 
                (int.Parse(counterCookie.Value) + 1).ToString();
            Response.SetCookie(counterCookie);
            ViewBag.Counter = counterCookie.Value;

            return View();
        }
    }
}