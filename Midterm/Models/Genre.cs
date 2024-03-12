using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Midterm.Models
{
    public partial class Genre
    {
        public Genre()
        {
            Books = new HashSet<Book>();
        }

        [Display(Name = "Genre ID")]
        public int GenreId { get; set; }

        [Display(Name = "Genre Description")]
        public string GenreType { get; set; } = null!;

        public virtual ICollection<Book> Books { get; set; }
    }
}
