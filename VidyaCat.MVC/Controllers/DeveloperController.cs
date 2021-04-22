using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidyaCat.Data;
using VidyaCat.Models.DeveloperModels;
using VidyaCat.Services;

namespace VidyaCat.MVC.Controllers
{
    public class DeveloperController : Controller
    {
        // GET: Developer
        public ActionResult Index()
        {
            var userID = Guid.Parse(User.Identity.GetUserId());
            var svc = new DeveloperService(userID);
            var model = svc.GetDevelopers();
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
        public ActionResult Create(DeveloperCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            var svc = CreateDeveloperService();
            if (svc.CreateDeveloper(model))
            {
                TempData["SaveResult"] = "Developer was successfully added to the database!";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "An error occurred while attempting to add the developer to the database - changes not saved.");
            return View(model);
        }

        // GET: Details
        public ActionResult Details(int id)
        {
            var svc = CreateDeveloperService();
            var model = svc.GetDeveloperByID(id);
            return View(model);
        }

        // GET: Developers by Region
        public ActionResult IndexByRegion(Region region)
        {
            var svc = CreateDeveloperService();
            var model = svc.GetDevelopersByRegion(region);
            return View(model);
        }

        // GET: Developers by Status   
        public ActionResult IndexByStatus(string status)
        {
            var svc = CreateDeveloperService();
            var model = svc.GetDevelopersByStatus(status);
            return View(model);
        }

        // GET: Developers by Type
        public ActionResult IndexByType(string type)
        {
            var svc = CreateDeveloperService();
            var model = svc.GetDevelopersByType(type);
            return View(model);
        }

        // GET: Edit
        public ActionResult Edit(int id)
        {
            var svc = CreateDeveloperService();
            var details = svc.GetDeveloperByID(id);
            var model = new DeveloperEdit
            {
                DeveloperID = details.DeveloperID,
                DeveloperName = details.DeveloperName,
                Region = details.Region,
                IsMajor = details.IsMajor,
                IsActive = details.IsActive
            };

            return View(model);
        }

        // POST: Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, DeveloperEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.DeveloperID != id)
            {
                ModelState.AddModelError("", "ID mismatch");
                return View(model);
            }

            var svc = CreateDeveloperService();
            if (svc.UpdateDeveloper(model))
            {
                TempData["SaveResult"] = "Developer info successfully updated!";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "An error occurred while attempting to edit the developer info - changes not saved.");
            return View(model);
        }

        // GET: Delete
        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var svc = CreateDeveloperService();
            var model = svc.GetDeveloperByID(id);
            return View(model);
        }

        // POST: Delete
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteDeveloper(int id)
        {
            var svc = CreateDeveloperService();
            svc.DeleteDeveloper(id);
            TempData["SaveResult"] = "Developer successfully deleted from the database.";
            return RedirectToAction("Index");
        }

        private DeveloperService CreateDeveloperService()
        {
            var userID = Guid.Parse(User.Identity.GetUserId());
            var svc = new DeveloperService(userID);
            return svc;
        }
    }
}