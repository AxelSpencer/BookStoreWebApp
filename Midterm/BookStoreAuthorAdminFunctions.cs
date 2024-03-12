using Midterm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    public class BookStoreAuthorAdminFunctions
    {
        public static void AddAuthor(Author author)
        {
            try
            {
                using (var db = new SE407_BookStoreContext())
                {
                    db.Authors.Add(author);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
            }
        }

        public static void DeleteAuthor(int id)
        {
            try
            {
                using (var db = new SE407_BookStoreContext())
                {
                    var authorToDelete = db.Authors.Find(id);
                    db.Authors.Remove(authorToDelete);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
            }
        }

        public static void EditAuthor(Author author)
        {
            try
            {
                using (var db = new SE407_BookStoreContext())
                {
                    db.Authors.Update(author);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
            }
        }
    }
}
