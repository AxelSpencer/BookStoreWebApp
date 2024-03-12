using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Midterm.Models
{
    public partial class Book
    {
        public Book()
        {
            Transactions = new HashSet<Transaction>();
        }

        [Display(Name = "Book ID")]
        public int BookId { get; set; }
        
        [Display(Name = "Title")]
        public string BookTitle { get; set; } = null!;

        [Display(Name = "Genre ID")]
        public int GenreId { get; set; }

        [Display(Name = "Author ID")]
        public int AuthorId { get; set; }

        [Display(Name = "Release Year")]
        public short YearOfRelease { get; set; }

        [Display(Name = "Author")]
        public virtual Author Author { get; set; } = null!;

        [Display(Name = "Genre")]
        public virtual Genre Genre { get; set; } = null!;
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
