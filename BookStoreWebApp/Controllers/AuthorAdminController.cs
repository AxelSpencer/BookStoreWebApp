using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Midterm;
using Midterm.Models;

namespace BookStoreWebApp.Controllers
{
    public class AuthorAdminController : Controller
    {
        // GET: AuthorAdminController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AuthorAdminController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AuthorAdminController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AuthorAdminController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Author authorToCreate)
        {
            try
            {
                BookStoreAuthorAdminFunctions.AddAuthor(authorToCreate);
                return RedirectToAction("Authors", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthorAdminController/Edit/5
        public ActionResult Edit(int id)
        {
            var author = BookStoreBasicFunctions.GetAuthorById(id);
            return View(author);
        }

        // POST: AuthorAdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Author authorToCreate)
        {
            try
            {
                BookStoreAuthorAdminFunctions.EditAuthor(authorToCreate);
                return RedirectToAction("Authors", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthorAdminController/Delete/5
        public ActionResult Delete(int id)
        {
            var author = BookStoreBasicFunctions.GetAuthorById(id);
            return View(author);
        }

        // POST: AuthorAdminController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Author author)
        {
            try
            {
                BookStoreAuthorAdminFunctions.DeleteAuthor(author.AuthorId);
                return RedirectToAction("Authors", "Home");
            }
            catch
            {
                return View();
            }
        }
    }
}
