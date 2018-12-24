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


        public ActionResult Search(PropertySearchViewModel viewModel)
        {
            var properties = ctx.Properties
                .Where(p => p.ValidUntilDate >= DateTime.Now);
            ViewBag.SearchLocationId = 
                new SelectList(ctx.Locations.ToList()
                    , "Id", "DisplayName", viewModel.SearchLocationId);

            if (viewModel.SearchForm == null)//درحالتی که فرم جستجو پر نشده
            {
                viewModel = new PropertySearchViewModel();
                viewModel.PropertyIds = properties.Select(p => p.Id).ToList();
                return View(viewModel);
            }
            else//درحالتی که فرم پر شده
            {
                if (viewModel.SearchTitle != null)
                {
                    properties = properties
                        .Where(p => p.Title.Contains(viewModel.SearchTitle));
                }
                if (viewModel.SearchAreaFrom != null)
                {
                    properties = properties
                        .Where(p => p.Area >= viewModel.SearchAreaFrom);
                }
                if (viewModel.SearchAreaTo != null)
                {
                    properties = properties
                        .Where(p => p.Area <= viewModel.SearchAreaTo);
                }
                if (viewModel.SearchAdType != null)
                {
                    properties = properties
                        .Where(p => p.AdType == viewModel.SearchAdType);

                }
                if (viewModel.SearchLocationId != null)
                {
                    properties = properties
                        .Where(p => p.LocationId == viewModel.SearchLocationId);
                }

                viewModel.PropertyIds =
                    properties
                    .Select(p => p.Id)
                    .OrderByDescending(i => i)
                    .ToList();

                return View(viewModel);
            }
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