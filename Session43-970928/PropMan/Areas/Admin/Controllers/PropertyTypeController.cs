using PropMan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace PropMan.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PropertyTypeController : Controller
    {
        private PropManDbContext ctx = new PropManDbContext();
        public ActionResult Index()
        {
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

            var propertType = ctx.PropertyTypes.Find(id);
            if (propertType == null)
            {
                //return new HttpStatusCodeResult(HttpStatusCode.NotFound);
                return HttpNotFound();
            }
            return View(propertType);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PropertyType propertyType)
        {
            if (ModelState.IsValid)
            {
                //var db_propretyType = ctx.PropertyTypes.Find(propertyType.Id);
                //db_propretyType.Name = propertyType.Name;
                ctx.Entry(propertyType).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
                TempData["Message"] = "نوع ملک با موفقیت ویرایش شد";
                return RedirectToAction("Index");
            }

            return View(propertyType);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var propertType = ctx.PropertyTypes.Find(id);
            if (propertType == null)
            {
                //return new HttpStatusCodeResult(HttpStatusCode.NotFound);
                return HttpNotFound();
            }
            return View(propertType);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var propertType = ctx.PropertyTypes.Find(id);
            if (propertType == null)
            {
                //return new HttpStatusCodeResult(HttpStatusCode.NotFound);
                return HttpNotFound();
            }

            ctx.PropertyTypes.Remove(propertType);
            ctx.SaveChanges();

            TempData["Message"] = $"نوع ملک {propertType.Name} با موفقیت حذف شد";
            return RedirectToAction("Index");
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