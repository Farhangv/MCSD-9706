using PropMan.Models;
using PropMan.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PropMan.Controllers
{
    public class HomeController : Controller
    {
        private PropManDbContext ctx = new PropManDbContext();
        public ActionResult Index()
        {
            var viewModel = ctx.Properties
                .Where(p => p.ValidUntilDate >= DateTime.Now)
                .OrderByDescending(p => p.Id)
                .Select(p => p.Id).ToList();
            
            return View(viewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                ctx.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}