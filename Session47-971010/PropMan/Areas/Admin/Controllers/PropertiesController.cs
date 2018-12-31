using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using MD.PersianDateTime;
using PropMan.Models;
using PropMan.ViewModels;

namespace PropMan.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PropertiesController : Controller
    {
        private PropManDbContext ctx = new PropManDbContext();

        //TODO: EDIT,DELETE,DETAILS
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
            ViewBag.LocationId = new SelectList(ctx.Locations, "Id", "District");
            ViewBag.PropertyTypeId = new SelectList(ctx.PropertyTypes, "Id", "Name");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PropertyCreateViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var property = new Property() {
                    Title = viewModel.Title,
                    AdType = viewModel.AdType,
                    Age = viewModel.Age,
                    Area = viewModel.Area,
                    BedRoomsCount = viewModel.BedRoomsCount,
                    CreatedDate = DateTime.Now,
                    IsActive = true,
                    LocationId = viewModel.LocationId,
                    Position = viewModel.Position,
                    PropertyTypeId = viewModel.PropertyTypeId,
                    RentDiposite = viewModel.RentDiposite,
                    RentMonthly = viewModel.RentMonthly,
                    SaleUnitPrice = viewModel.SaleUnitPrice,
                    ValidUntilDate = PersianDateTime.Parse(viewModel.ValidUntilPersianDate).ToDateTime(),
                    CreatedUserId = ctx.Users.Where(u => u.UserName == User.Identity.Name).FirstOrDefault().Id
                    
                };
                ctx.Properties.Add(property);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.LocationId = new SelectList(ctx.Locations, "Id", "District");
            ViewBag.PropertyTypeId = new SelectList(ctx.PropertyTypes, "Id", "Name");
            return View(viewModel);
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

            var viewModel = new PropertyEditViewModel()
            {
                Id = property.Id,
                AdType = property.AdType,
                Age = property.Age,
                Area = property.Area,
                BedRoomsCount = property.BedRoomsCount,
                Description = property.Description,
                LocationId = property.LocationId,
                Position = property.Position,
                PropertyTypeId = property.PropertyTypeId,
                RentDiposite = property.RentDiposite,
                RentMonthly = property.RentMonthly,
                SaleUnitPrice = property.SaleUnitPrice,
                Title = property.Title,
                ValidUntilPersianDate = (new PersianDateTime(property.ValidUntilDate)).ToShortDateString()
            };

            ViewBag.LocationId = new SelectList(ctx.Locations, "Id", "District", property.LocationId);
            ViewBag.PropertyTypeId = new SelectList(ctx.PropertyTypes, "Id", "Name", property.PropertyTypeId);
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PropertyEditViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var property = new Property()
                {
                    Id = viewModel.Id,
                    Title = viewModel.Title,
                    AdType = viewModel.AdType,
                    Age = viewModel.Age,
                    Area = viewModel.Area,
                    BedRoomsCount = viewModel.BedRoomsCount,
                    CreatedDate = DateTime.Now,
                    IsActive = true,
                    LocationId = viewModel.LocationId,
                    Position = viewModel.Position,
                    PropertyTypeId = viewModel.PropertyTypeId,
                    RentDiposite = viewModel.RentDiposite,
                    RentMonthly = viewModel.RentMonthly,
                    SaleUnitPrice = viewModel.SaleUnitPrice,
                    ValidUntilDate = PersianDateTime.Parse(viewModel.ValidUntilPersianDate).ToDateTime()
                    //TODO: Add Created User
                };
                ctx.Entry(property).State = EntityState.Modified;
                ctx.SaveChanges();
                TempData["Message"] = "آگهی با موفقیت ویرایش شد";
                return RedirectToAction("Index");
            }
            ViewBag.LocationId = new SelectList(ctx.Locations, "Id", "District");
            ViewBag.PropertyTypeId = new SelectList(ctx.PropertyTypes, "Id", "Name");
            return View(viewModel);
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


        public ActionResult MediaManagement(int? id)
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
            var medias = property.Medias.ToList();
            ViewBag.PropertyId = id;
            return View(medias);
        }

        [HttpPost]
        public async Task<ActionResult> AddMedia(PropertyAddMediaViewModel viewModel)
        {
            var originalFileName = viewModel.Media.FileName;
            var extension = Path.GetExtension(originalFileName).ToLower();//.jpg
            var fileSize = viewModel.Media.ContentLength / 1024 / 1024;

            if (!(extension == ".jpg" || extension == ".png" ||
                extension == ".gif" || extension == ".jpeg" ||
                extension == ".mp4" || extension == ".pdf"))
            {
                ModelState.AddModelError("Media", "نوع فایل مجاز نیست");
            }

            if (fileSize > 10) //10MB
            {
                ModelState.AddModelError("Media", "فایل ارسالی باید کوچکتر از ۱۰ مگابایت باشد");
            }


            if (ModelState.IsValid)
            {
                var media = new Media()
                {
                    ContentType = viewModel.Media.ContentType,
                    FileSize = viewModel.Media.ContentLength,
                    OriginalFileName = originalFileName,
                    PropertyId = viewModel.PropertyId
                };

                using (MemoryStream ms = new MemoryStream())//Create Stream in RAM
                {
                    viewModel.Media.InputStream.CopyTo(ms);//Copy Uploaded File Stream to Stream in RAM
                    media.FileContent = ms.ToArray();//Convert Memory Stream to Byte Array
                }

                ctx.Medias.Add(media);
                await ctx.SaveChangesAsync();
                
                TempData["Message"] = "رسانه با موفقیت افزوده شد";
                return RedirectToAction("MediaManagement", new { id = viewModel.PropertyId });
            }
            ViewBag.PropertyId = viewModel.PropertyId;
            return View("MediaManagement", viewModel);
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
