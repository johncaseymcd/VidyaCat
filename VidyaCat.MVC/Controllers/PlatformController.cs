using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidyaCat.Services;
using VidyaCat.Data;
using VidyaCat.Models.PlatformModels;

namespace VidyaCat.MVC.Controllers
{
    public class PlatformController : Controller
    {
        // GET: Platform
        public ActionResult Index()
        {
            var userID = Guid.Parse(User.Identity.GetUserId());
            var svc = new PlatformService(userID);
            var model = svc.GetPlatforms();
            return View(model);
        }

        // GET: Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PlatformCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            var svc = CreatePlatformService();

            if (svc.CreatePlatform(model))
            {
                TempData["SaveResult"] = "Platform was successfully added to database!";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "An error occurred while attempting to add the platform to the database - changes not saved.");
            return View(model);
        }

        // GET: Details
        public ActionResult Details(int id)
        {
            var svc = CreatePlatformService();
            var model = svc.GetPlatformByID(id);
            return View(model);
        }

        // GET: Platforms by Year
        public ActionResult IndexByYear(int releaseYear)
        {
            var svc = CreatePlatformService();
            var model = svc.GetPlatformsByYear(releaseYear);
            return View(model);
        }

        // GET: Platforms by Brand
        public ActionResult IndexByBrand(Brand brand)
        {
            var svc = CreatePlatformService();
            var model = svc.GetPlatformsByBrand(brand);
            return View(model);
        }

        // GET: Platforms by Status
        public ActionResult IndexByStatus(string status)
        {
            var svc = CreatePlatformService();
            var model = svc.GetPlatformsByStatus(status);
            return View(model);
        }

        // GET: Edit
        public ActionResult Edit(int id)
        {
            var svc = CreatePlatformService();
            var details = svc.GetPlatformByID(id);
            var model = new PlatformEdit
            {
                PlatformID = details.PlatformID,
                Brand = details.Brand,
                PlatformName = details.PlatformName,
                ReleaseDate = details.ReleaseDate
            };
            return View(model);
        }

        // POST: Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PlatformEdit model)
        {
            if (!ModelState.IsValid) return View(model);
            
            if (model.PlatformID != id)
            {
                ModelState.AddModelError("", "ID mismatch");
                return View(model);
            }

            var svc = CreatePlatformService();
            if (svc.UpdatePlatform(model))
            {
                TempData["SaveResult"] = "Platform info was successfully updated!";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "An error occurred while attempting to update the platform info - changes not saved.");
            return View(model);
        }

        // GET: Delete
        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var svc = CreatePlatformService();
            var model = svc.GetPlatformByID(id);
            return View(model);
        }

        // POST: Delete
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePlatform(int id)
        {
            var svc = CreatePlatformService();
            svc.DeletePlatform(id);
            TempData["SaveResult"] = "Platform was successfully deleted!";
            return RedirectToAction("Index");
        }

        private PlatformService CreatePlatformService()
        {
            var userID = Guid.Parse(User.Identity.GetUserId());
            var svc = new PlatformService(userID);
            return svc;
        }
    }
}