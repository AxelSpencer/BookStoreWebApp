using Midterm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    public class BookStoreGenreAdminFunctions
    {
        public static void AddGenre(Genre genre)
        {
            try
            {
                using (var db = new SE407_BookStoreContext())
                {
                    db.Genres.Add(genre);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
            }
        }

        public static void DeleteGenre(int id)
        {
            try
            {
                using (var db = new SE407_BookStoreContext())
                {
                    var genreToDelete = db.Genres.Find(id);
                    db.Genres.Remove(genreToDelete);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
            }
        }

        public static void EditGenre(Genre genre)
        {
            try
            {
                using (var db = new SE407_BookStoreContext())
                {
                    db.Genres.Update(genre);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
            }
        }
    }
}
