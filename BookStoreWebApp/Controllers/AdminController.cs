using BookStoreWebApp.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Midterm;
using Midterm.Models;

namespace BookStoreWebApp.Controllers
{
    public class AdminController : Controller
    {
        // GET: AdminController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AdminController/Details/5
        public ActionResult Details(int id)
        {
            var book = BookStoreBasicFunctions.GetBookById(id);
            return View(book);
        }

        // GET: AdminController/Create
        public ActionResult Create()
        {
            ViewBag.GenreId = DropDownFormatter.FormatGenres();
            ViewBag.AuthorId = DropDownFormatter.FormatAuthors();
            return View();
        }

        // POST: AdminController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Book bookToCreate)
        {
            try
            {
                BookStoreAdminFunctions.AddBook(bookToCreate);
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Edit/5
        public ActionResult Edit(int id)
        {
            var book = BookStoreBasicFunctions.GetBookById(id);
            ViewBag.GenreId = DropDownFormatter.FormatGenres();
            ViewBag.AuthorId = DropDownFormatter.FormatAuthors();
            return View(book);
        }

        // POST: AdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Book bookToEdit)
        {
            try
            {
                BookStoreAdminFunctions.EditBook(bookToEdit);
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Delete/5
        public ActionResult Delete(int id)
        {
            var book = BookStoreBasicFunctions.GetBookById(id);
            return View(book);
        }

        // POST: AdminController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Book book)
        {
            try
            {
                BookStoreAdminFunctions.DeleteBook(book.BookId);
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }
    }
}
