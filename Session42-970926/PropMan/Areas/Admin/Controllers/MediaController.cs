using PropMan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace PropMan.Areas.Admin.Controllers
{
    public class MediaController : Controller
    {
        private PropManDbContext ctx = new PropManDbContext();

        public ActionResult GetMedia(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Media media = ctx.Medias.Find(id);
            if (media == null)
            {
                return HttpNotFound();
            }

            return File(media.FileContent, media.ContentType);
        }

        [HttpPost]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Media media = ctx.Medias.Find(id);
            if (media == null)
            {
                return HttpNotFound();
            }

            ctx.Medias.Remove(media);
            ctx.SaveChanges();

            return new HttpStatusCodeResult(200);
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