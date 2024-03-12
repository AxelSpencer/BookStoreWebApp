using BookStoreWebApp.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Midterm;
using Midterm.Models;

namespace BookStoreWebApp.Controllers
{
    public class GenreAdminController : Controller
    {
        // GET: GenreAdminController
        public ActionResult Index()
        {
            return View();
        }

        // GET: GenreAdminController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GenreAdminController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GenreAdminController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Genre genreToCreate)
        {
            try
            {
                BookStoreGenreAdminFunctions.AddGenre(genreToCreate);
                return RedirectToAction("Genres", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: GenreAdminController/Edit/5
        public ActionResult Edit(int id)
        {
            var genre = BookStoreBasicFunctions.GetGenreById(id);
            return View(genre);
        }

        // POST: GenreAdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Genre genreToCreate)
        {
            try
            {
                BookStoreGenreAdminFunctions.EditGenre(genreToCreate);
                return RedirectToAction("Genres", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: GenreAdminController/Delete/5
        public ActionResult Delete(int id)
        {
            var genre = BookStoreBasicFunctions.GetGenreById(id);
            return View(genre);
        }

        // POST: GenreAdminController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Genre genre)
        {
            try
            {
                BookStoreGenreAdminFunctions.DeleteGenre(genre.GenreId);
                return RedirectToAction("Genres", "Home");
            }
            catch
            {
                return View();
            }
        }
    }
}
