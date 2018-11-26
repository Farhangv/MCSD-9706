using PropMan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PropMan.Areas.Admin.Controllers
{
    public class PropertyTypeController : Controller
    {

        //TODO: Context Dispose
        public ActionResult Index()
        {
            PropManDbContext ctx = new PropManDbContext();
            var propertyTypes = ctx.PropertyTypes.ToList();
            return View(propertyTypes);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PropertyType model)
        {

            //TODO: Model Validation
            PropManDbContext ctx = new PropManDbContext();
            ctx.PropertyTypes.Add(model);
            ctx.SaveChanges();

            //TODO: Temp Message

            return RedirectToAction("Index");
        }
    }
}