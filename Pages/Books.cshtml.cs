using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using Fisher.BookStore.Models;
using System.Collections.Generic;

namespace Fisher.BookStore.Pages
{
    public class Books : PageModel
    {

        public List<Book> books;

        public void OnGet()
        {
            books = new List<Book>();

            books.Add(new Book()
            {
                Title = "Countinuous Delivery",
                Author = new Author() { Name = "Jez Humble"}
            });

            books.Add(new Book()
            {
                Title = "Lean Enterprise",
                Author = new Author() { Name = "Barry O'Reilly"}
            });

            books.Add(new Book()
            {
                Title = "The Goal",
                Author = new Author() { Name = "Eliyahu Goldratt"}
            });
        }
    }
}

