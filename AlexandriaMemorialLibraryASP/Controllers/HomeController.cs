using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AlexandriaMemorialLibraryASP.Models;
using System.IO;

namespace AlexandriaMemorialLibraryASP.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public List<BookModel> Library { get; set; }
        private bool Loop { get; set; }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            this.Library = new List<BookModel>();
            GenerateLibrary();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult BookModelView(BookModel passthrough)
        {
            return View(passthrough);
        }
        public IActionResult LibraryView(List<BookModel> library)
        {
            library = this.Library;
            return View(library);
        }
        public IActionResult Details(int id)
        {
            return BookModelView();
        }
        private void GenerateLibrary()
        {
            Library.Add(new BookModel()
            {
                Title = "Best of Bar Harbor",
                Author = "Greg Hartford",
                ISBN = 9780892727940,
                Status = Status.OnShelf,
                Genre = new List<Genre> { Genre.Travel },
                DueDate = new DateTime(1800, 1, 1)
            }
            );
            Library.Add(new BookModel()
            {
                Title = "Dune",
                Author = "Frank Herbert",
                ISBN = 9780593099322,
                Status = Status.OnShelf,
                Genre = new List<Genre>() { Genre.SciFi, Genre.Adventure, Genre.Fantasy },
                DueDate = new DateTime(1800, 1, 1)
            }
            );
            Library.Add(new BookModel()
            {
                Title = "Every Tool's a Hammer",
                Author = "Adam Savage",
                ISBN = 9781471185113,
                Status = Status.OnShelf,
                Genre = new List<Genre>() { Genre.Biography },
                DueDate = new DateTime(1800, 1, 1)
            }
            );
            Library.Add(new BookModel()
            {
                Title = "Excelsior!: The Amazing Life of Stan Lee",
                Author = "Stan Lee",
                ISBN = 9780684873053,
                Status = Status.OnShelf,
                Genre = new List<Genre> { Genre.Biography },
                DueDate = new DateTime(1800, 1, 1)
            }
            );
            Library.Add(new BookModel()
            {
                Title = "The Food Lab: Better Home Cooking Through Science",
                Author = "J. Kenji López-Alt",
                ISBN = 9780393081084,
                Status = Status.OnShelf,
                Genre = new List<Genre> { Genre.SelfHelp },
                DueDate = new DateTime(1800, 1, 1)
            }
            );
            Library.Add(new BookModel()
            {
                Title = "The Hobbit: Or There and Back Again",
                Author = "J.R.R. Tolkien",
                ISBN = 9781594130052,
                Status = Status.OnShelf,
                Genre = new List<Genre> { Genre.Adventure, Genre.Fantasy },
                DueDate = new DateTime(1800, 1, 1)
            }
            );
            Library.Add(new BookModel()
            {
                Title = "The Institute",
                Author = "Stephen King",
                ISBN = 9781982110567,
                Status = Status.OnShelf,
                Genre = new List<Genre> { Genre.Thriller },
                DueDate = new DateTime(1800, 1, 1)
            }
            );
            Library.Add(new BookModel()
            {
                Title = "Journey to the Center of the Earth",
                Author = "Jules Verne",
                ISBN = 9780553213973,
                Status = Status.OnShelf,
                Genre = new List<Genre> { Genre.SciFi, Genre.Adventure },
                DueDate = new DateTime(1800, 1, 1)
            }
            );
            Library.Add(new BookModel()
            {
                Title = "The Line Between",
                Author = "Tosca Lee",
                ISBN = 9781476798622,
                Status = Status.OnShelf,
                Genre = new List<Genre> { Genre.SciFi, Genre.Thriller },
                DueDate = new DateTime(1800, 1, 1)
            }
            );
            Library.Add(new BookModel()
            {
                Title = "The Martian",
                Author = "Andy Weir",
                ISBN = 9780553418026,
                Status = Status.OnShelf,
                Genre = new List<Genre> { Genre.SciFi, Genre.Adventure },
                DueDate = new DateTime(1800, 1, 1)
            }
            );
            Library.Add(new BookModel()
            {
                Title = "Mud, Sweat, and Tears",
                Author = "Bear Grylls",
                ISBN = 9780062124135,
                Status = Status.OnShelf,
                Genre = new List<Genre>() { Genre.Biography },
                DueDate = new DateTime(1800, 1, 1)
            }
            );
            Library.Add(new BookModel()
            {
                Title = "Murder on the Orient Express",
                Author = "Agatha Christie",
                ISBN = 9781579126230,
                Status = Status.OnShelf,
                Genre = new List<Genre> { Genre.Mystery },
                DueDate = new DateTime(1800, 1, 1)
            }
            );
            Library.Add(new BookModel()
            {
                Title = "Permanent Record",
                Author = "Edward Snowden",
                ISBN = 9781250237231,
                Status = Status.OnShelf,
                Genre = new List<Genre> { Genre.Biography },
                DueDate = new DateTime(1800, 1, 1)
            }
            );
            Library.Add(new BookModel()
            {
                Title = "Radicalized",
                Author = "Cory Doctorow",
                ISBN = 9781250228598,
                Status = Status.OnShelf,
                Genre = new List<Genre>() { Genre.SciFi, },
                DueDate = new DateTime(1800, 1, 1)
            }
            );
            Library.Add(new BookModel()
            {
                Title = "The Secrets of Ireland",
                Author = "Kevin Eyres",
                ISBN = 9780760782811,
                Status = Status.OnShelf,
                Genre = new List<Genre> { Genre.Travel },
                DueDate = new DateTime(1800, 1, 1)
            }
            );
            Library.Add(new BookModel()
            {
                Title = "Shoe Dog",
                Author = "Phil Knight",
                ISBN = 9781501135927,
                Status = Status.OnShelf,
                Genre = new List<Genre> { Genre.Biography },
                DueDate = new DateTime(1800, 1, 1)
            }
             );
            Library.Add(new BookModel()
            {
                Title = "Spartan Gold",
                Author = "Clive Cussler",
                ISBN = 9780425236291,
                Status = Status.OnShelf,
                Genre = new List<Genre> { Genre.Adventure },
                DueDate = new DateTime(1800, 1, 1)
            }
            );
            Library.Add(new BookModel()
            {
                Title = "Turn Right At Machu Picchu",
                Author = "Mark Adams",
                ISBN = 9780452297982,
                Status = Status.OnShelf,
                Genre = new List<Genre> { Genre.Travel },
                DueDate = new DateTime(1800, 1, 1)
            }
            );
            Library.Add(new BookModel()
            {
                Title = "Watchmen",
                Author = "Alan Moore",
                ISBN = 9781779501129,
                Status = Status.OnShelf,
                Genre = new List<Genre>() { Genre.GraphicNovel, Genre.Mystery, Genre.SciFi },
                DueDate = new DateTime(1800, 1, 1)
            }
            );
            Library.Add(new BookModel()
            {
                Title = "World War Z",
                Author = "Max Brooks",
                ISBN = 9780307346612,
                Status = Status.OnShelf,
                Genre = new List<Genre>() { Genre.SciFi, Genre.Adventure, Genre.Thriller },
                DueDate = new DateTime(1800, 1, 1)
            }
            );
        }
        //public void Burn()
        //{
        //    //input for confirmation: hail caesar
        //    if (confirm == "hail caesar")
        //    {
        //        this.Library = new List<BookModel>();
        //        Library.Add(new BookModel()
        //        {
        //            Title = "Charred Remains",
        //            Author = "Julius Caesar",
        //            ISBN = 1234567890123,
        //            Status = Status.Unavailable,
        //            Genre = new List<Genre> { Genre.SelfHelp },
        //            DueDate = new DateTime(1800, 1, 1)
        //        }
        //    );
        //    }
        //}
        public List<BookModel> SearchTitle(string title)
        {
            List<BookModel> searchResults = new List<BookModel>();
            List<char> delimiters = new List<char>() { ' ', ',', '\'', '?', '.', '!', '"', ':', '-', '&' };
            title = title.Trim().ToLower();
            for (int i = 0; i < title.Length; i++)
            {
                if (delimiters.Contains(title[i]))
                {
                    title = title.Remove(i, 1);
                }
            }
            foreach (BookModel book in Library)
            {
                string compare = book.Title.Trim().ToLower();
                for (int i = 0; i < compare.Length; i++)
                {
                    if (delimiters.Contains(compare[i]))
                    {
                        compare = compare.Remove(i,1);
                    }
                }
                if (compare.Contains(title))
                {
                    searchResults.Add(book);
                }
            }
            return searchResults;
        }
        public List<BookModel> SearchAuthor(string author)
        {
            List<BookModel> searchResults = new List<BookModel>();
            List<char> delimiters = new List<char>() { ' ', ',', '\'', '?', '.', '!', '"', ':', '-', '&' };
            author = author.Trim().ToLower();
            for (int i = 0; i < author.Length; i++)
            {
                if (delimiters.Contains(author[i]))
                {
                    author = author.Remove(i, 1);
                }
            }
            foreach (BookModel book in Library)
            {
                string compare = book.Author.Trim().ToLower();
                for (int i = 0; i < compare.Length; i++)
                {
                    if (delimiters.Contains(compare[i]))
                    {
                        compare = compare.Remove(i, 1);
                    }
                }
                if (compare.Contains(author))
                {
                    searchResults.Add(book);
                }
            }
            return searchResults;
        }
        public List<BookModel> SearchISBN(ulong isbn)
        {
            List<BookModel> searchResults = new List<BookModel>();
            foreach (BookModel book in Library)
            {
                if (book.ISBN == isbn)
                {
                    searchResults.Add(book);
                }
            }
            return searchResults;
        }
        public List<BookModel> SearchGenre(Genre genre)
        {
            List<BookModel> searchResults = new List<BookModel>();
            foreach (BookModel book in Library)
            {
                List<Genre> compare = book.Genre;
                foreach (Genre check in compare)
                {
                    if (genre == check)
                    {
                        searchResults.Add(book);
                    }
                }
            }
            return searchResults;
        }
    }
}
