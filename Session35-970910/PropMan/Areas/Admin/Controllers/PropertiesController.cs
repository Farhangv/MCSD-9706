using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PropMan.Models;

namespace PropMan.Areas.Admin.Controllers
{
    public class PropertiesController : Controller
    {
        private PropManDbContext ctx = new PropManDbContext();

        public ActionResult Index()
        {
            var properties = ctx.Properties
                .Include(p => p.CreatedUser)
                .Include(p => p.Location)
                .Include(p => p.PropertyType);
            return View(properties.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Property property = ctx.Properties.Find(id);
            if (property == null)
            {
                return HttpNotFound();
            }
            return View(property);
        }

        public ActionResult Create()
        {
            ViewBag.CreatedUserId = new SelectList(ctx.Users, "Id", "Name");
            ViewBag.LocationId = new SelectList(ctx.Locations, "Id", "Country");
            ViewBag.PropertyTypeId = new SelectList(ctx.PropertyTypes, "Id", "Name");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Property property)
        {
            if (ModelState.IsValid)
            {
                ctx.Properties.Add(property);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CreatedUserId = new SelectList(ctx.Users, "Id", "Name", property.CreatedUserId);
            ViewBag.LocationId = new SelectList(ctx.Locations, "Id", "Country", property.LocationId);
            ViewBag.PropertyTypeId = new SelectList(ctx.PropertyTypes, "Id", "Name", property.PropertyTypeId);
            return View(property);
        }

        // GET: Admin/Properties/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Property property = ctx.Properties.Find(id);
            if (property == null)
            {
                return HttpNotFound();
            }
            ViewBag.CreatedUserId = new SelectList(ctx.Users, "Id", "Name", property.CreatedUserId);
            ViewBag.LocationId = new SelectList(ctx.Locations, "Id", "Country", property.LocationId);
            ViewBag.PropertyTypeId = new SelectList(ctx.PropertyTypes, "Id", "Name", property.PropertyTypeId);
            return View(property);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Property property)
        {
            if (ModelState.IsValid)
            {
                ctx.Entry(property).State = EntityState.Modified;
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CreatedUserId = new SelectList(ctx.Users, "Id", "Name", property.CreatedUserId);
            ViewBag.LocationId = new SelectList(ctx.Locations, "Id", "Country", property.LocationId);
            ViewBag.PropertyTypeId = new SelectList(ctx.PropertyTypes, "Id", "Name", property.PropertyTypeId);
            return View(property);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Property property = ctx.Properties.Find(id);
            if (property == null)
            {
                return HttpNotFound();
            }
            return View(property);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Property property = ctx.Properties.Find(id);
            ctx.Properties.Remove(property);
            ctx.SaveChanges();
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
