﻿using Microsoft.AspNetCore.Mvc.Rendering;
using Midterm.Models;
using Midterm;

namespace BookStoreWebApp.Helpers
{
    public class DropDownFormatter
    {
        public static SelectList FormatAuthors()
        {
            return new SelectList(BookStoreBasicFunctions.GetAllAuthors()
                .OrderBy(a => a.AuthorLast)
                .ToDictionary(a => a.AuthorId, a => a.AuthorLast + ", " + a.AuthorFirst), "Key", "Value");
        }

        public static SelectList FormatGenres()
        {
            return new SelectList(BookStoreBasicFunctions.GetAllGenres()
                .OrderBy(g => g.GenreType)
                .ToDictionary(g => g.GenreId, g => g.GenreType), "Key", "Value");
        }
    }
}
