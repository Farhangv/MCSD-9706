using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using PropMan.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace PropMan.Areas.Admin.Controllers
{
    public class UsersController : Controller
    {
        private PropManDbContext ctx = new PropManDbContext();

        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;

        public ApplicationSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
            }
            private set
            {
                _signInManager = value;
            }
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }


        public UsersController()
        {
        }

        public UsersController(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }


        public ActionResult Index()
        {
            return View(ctx.Users.ToList());
        }

        public ActionResult Create()
        {
            ViewBag.RoleName = new SelectList(ctx.Roles, "Name", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserCreateViewModel model)
        {
            var originalFileName = model.Photo.FileName;
            var extension = Path.GetExtension(originalFileName).ToLower();//.jpg
            var fileSize = model.Photo.ContentLength / 1024 / 1024;

            if (!(extension == ".jpg" || extension == ".png" ||
                extension == ".gif" || extension == ".jpeg"))
            {
                ModelState.AddModelError("Photo", "نوع فایل مجاز نیست");
            }
            if (fileSize > 2) //2MB
            {
                ModelState.AddModelError("Photo", "فایل ارسالی باید کوچکتر از ۲ مگابایت باشد");
            }

            if (ModelState.IsValid)
            {
                var fileName = $"{Guid.NewGuid().ToString()}{extension}";
                model.Photo.SaveAs(Server.MapPath($"~/Photos/Users/{fileName}"));

                var user = new ApplicationUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                    Name = model.Name,
                    Family = model.Family,
                    PhotoFilePath = fileName
                };
                var result = UserManager.Create(user, model.Password);
                if (result.Succeeded)//اگر کاربر با موفقیت ثبت شد
                {
                    UserManager.AddToRole(user.Id, model.RoleName);
                    SignInManager.SignIn(user, isPersistent: false, rememberBrowser: false);
                    return RedirectToAction("Index");
                }
                AddErrors(result);
            }
            return View(model);

        }

        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicationUser user = ctx.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }

            ViewBag.RoleName = new SelectList(ctx.Roles, "Name", "Name", ctx.Roles.Find(user.Roles.FirstOrDefault().RoleId));
            var viewModel = new UserEditViewModel()
            {
                Id = user.Id,
                Email = user.Email,
                Family = user.Family,
                Name = user.Name,
                PhotoFilePath = user.PhotoFilePath,
                RoleName = ctx.Roles.Find(user.Roles.FirstOrDefault().RoleId).Name
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UserEditViewModel model)
        {
            var passwordChanged = false;
            var user = ctx.Users.Find(model.Id);

            if (model.Photo != null)
            {
                var extension = Path.GetExtension(model.Photo.FileName).ToLower();//.jpg
                var fileSize = model.Photo.ContentLength / 1024 / 1024;

                if (!(extension == ".jpg" || extension == ".png" ||
                    extension == ".gif" || extension == ".jpeg"))
                {
                    ModelState.AddModelError("Photo", "نوع فایل مجاز نیست");
                }
                if (fileSize > 2) //2MB
                {
                    ModelState.AddModelError("Photo", "فایل ارسالی باید کوچکتر از ۲ مگابایت باشد");
                }

                var fileName = $"{Guid.NewGuid().ToString()}{extension}";
                model.Photo.SaveAs(Server.MapPath($"~/Photos/Users/{fileName}"));
                user.PhotoFilePath = fileName;
            }
            if (ModelState.IsValid)
            {
                user.UserName = model.Email;
                user.Email = model.Email;
                user.Name = model.Name;
                user.Family = model.Family;
                var result = UserManager.Create(user, model.Password);
                if (result.Succeeded)//اگر کاربر با موفقیت ثبت شد
                {
                    UserManager.AddToRole(user.Id, model.RoleName);
                    SignInManager.SignIn(user, isPersistent: false, rememberBrowser: false);
                    return RedirectToAction("Index");
                }
                AddErrors(result);
            }
            return View(model);


        }
        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
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