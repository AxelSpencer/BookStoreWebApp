using Microsoft.EntityFrameworkCore;
using Midterm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    public class BookStoreBasicFunctions
    {
        public static Book GetBookByTitle(string title)
        {
            using (var db = new SE407_BookStoreContext())
            {
                return db.Books.FirstOrDefault(b => b.BookTitle == title);
            }
        }

        public static List<Book> GetAllBooks()
        {
            using (var db = new SE407_BookStoreContext())
            {
                return db.Books
                    .Include(b => b.Genre)
                    .Include(b => b.Author)
                    .ToList();
            }
        }

        public static List<Book> GetAllBooksByAuthorLastName(string lastName)
        {
            using (var db = new SE407_BookStoreContext())
            {
                return db.Books
                    .Where(b => b.Author.AuthorLast == lastName)
                    .ToList();
            }
        }

        public static Book GetBookById(int id)
        {
            using (var db = new SE407_BookStoreContext())
            {
                var book = db.Books
                    .Include (b => b.Genre)
                    .Include(b => b.Author)
                    .Where(b => b.BookId == id)
                    .FirstOrDefault();
                return book;
            }
        }

        public static Genre GetGenreById(int id)
        {
            using (var db = new SE407_BookStoreContext())
            {
                var genre = db.Genres
                    .Where(b => b.GenreId == id)
                    .FirstOrDefault();
                return genre;
            }
        }

        public static Author GetAuthorById(int id)
        {
            using (var db = new SE407_BookStoreContext())
            {
                var author = db.Authors
                    .Where(b => b.AuthorId == id)
                    .FirstOrDefault();
                return author;
            }
        }

        public static List<Genre> GetAllGenres()
        {
            using (var db = new SE407_BookStoreContext())
            {
                return db.Genres.ToList();
            }
        }

        public static List<Author> GetAllAuthors()
        {
            using (var db = new SE407_BookStoreContext())
            {
                return db.Authors.ToList();
            }
        }
    }
}
