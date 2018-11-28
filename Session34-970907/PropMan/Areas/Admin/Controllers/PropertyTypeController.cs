using PropMan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
            if (model.Name == "تجاری")
                ModelState.AddModelError("", "افزودن نوع ملک تجاری مجاز نیست");

            if (ModelState.IsValid)
            {
                PropManDbContext ctx = new PropManDbContext();
                ctx.PropertyTypes.Add(model);
                ctx.SaveChanges();
                TempData["Message"] = $"نوع ملک {model.Name} با موفقیت افزوده شد.";
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var ctx = new PropManDbContext();
            var propertType = ctx.PropertyTypes.Find(id);
            if (propertType == null)
            {
                //return new HttpStatusCodeResult(HttpStatusCode.NotFound);
                return HttpNotFound();
            }

            return View(propertType);

        }
    }
}