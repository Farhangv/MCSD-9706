using PropMan.Models;
using PropMan.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace PropMan.Controllers
{
    public class PropertiesController : Controller
    {
        private PropManDbContext ctx = new PropManDbContext();

        [ChildActionOnly]
        public ActionResult PropertyBox(int? id)
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
            var viewModel = new PropertyItemViewModel()
            {
                Id = property.Id,
                PriceText = property.AdType == AdType.Sale ? $"{property.SaleUnitPrice * property.Area:#,###} تومان" : $"رهن: {property.RentDiposite:#,###} / اجاره: {property.RentMonthly:#,###}",
                Title = property.Title,
                PhotoPath = property.Medias.Where(m => m.ContentType.Contains("image")).Count() > 0 ?
                Url.Action("GetMedia", "Media", new { area = "", id = property.Medias?.Where(m => m.ContentType.Contains("image")).FirstOrDefault()?.Id }) :
                        ""
            };
            return PartialView("_PropertyBox", viewModel);
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