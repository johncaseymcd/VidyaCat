using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidyaCat.Data;
using VidyaCat.Models.GameModels;
using VidyaCat.Services;

namespace VidyaCat.MVC.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index()
        {
            var userID = Guid.Parse(User.Identity.GetUserId());
            var svc = new GameService(userID);
            var model = svc.GetGames();
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
        public ActionResult Create(GameCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            var svc = CreateGameService();
            if (svc.CreateGame(model))
            {
                TempData["SaveResult"] = "Game successfully added to database.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "An error occurred while attempting to add the game to the database - changes not saved.");
            return View(model);
        }

        // GET: Details
        public ActionResult Details(int id)
        {
            var svc = CreateGameService();
            var model = svc.GetGameByID(id);
            return View(model);
        }

        // GET: Games by Developer
        public ActionResult IndexByDeveloper(string devName)
        {
            var svc = CreateGameService();
            var model = svc.GetGamesByDeveloper(devName);
            return View(model);
        }

        // GET: Games by Platform
        public ActionResult IndexByPlatform(string platName)
        {
            var svc = CreateGameService();
            var model = svc.GetGamesByPlatform(platName);
            return View(model);
        }

        // GET: Games By Year
        public ActionResult IndexByReleaseYear(int releaseYear)
        {
            var svc = CreateGameService();
            var model = svc.GetGamesByYear(releaseYear);
            return View(model);
        }

        // GET: Games by Genre
        public ActionResult IndexByGenre(Genre genre)
        {
            var svc = CreateGameService();
            var model = svc.GetGamesByGenre(genre);
            return View(model);
        }

        // GET: Games by Rating
        public ActionResult IndexByRating(Rating rating)
        {
            var svc = CreateGameService();
            var model = svc.GetGamesByRating(rating);
            return View(model);
        }

        // GET: Edit
        public ActionResult Edit(int id)
        {
            var svc = CreateGameService();
            var detail = svc.GetGameByID(id);
            var model = new GameEdit
            {
                GameID = detail.GameID,
                Title = detail.Title,
                ReleaseDate = detail.ReleaseDate,
                Genre = detail.Genre,
                FirstSubgenre = detail.FirstSubgenre,
                SecondSubgenre = detail.SecondSubgenre,
                ThirdSubgenre = detail.ThirdSubgenre,
                PlatformNames = detail.PlatformNames,
                DeveloperName = detail.DeveloperName
            };

            return View(model);
        }

        // POST: Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, GameEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.GameID != id)
            {
                ModelState.AddModelError("", "ID mismatch");
                return View(model);
            }

            var svc = CreateGameService();
            if (svc.UpdateGame(model))
            {
                TempData["SaveResult"] = "The game info was succesfully updated!";
                return View(model);
            }

            ModelState.AddModelError("", "An error occurred while attempting to edit game info - changes not saved.");
            return View(model);
        }

        // GET: Delete
        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var svc = CreateGameService();
            var model = svc.GetGameByID(id);
            return View(model);
        }

        // POST: Delete
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteGame(int id)
        {
            var svc = CreateGameService();
            svc.DeleteGame(id);
            TempData["SaveResult"] = "Game successfully deleted from database.";
            return RedirectToAction("Index");
        }

        private GameService CreateGameService()
        {
            var userID = Guid.Parse(User.Identity.GetUserId());
            var svc = new GameService(userID);
            return svc;
        }
    }
}