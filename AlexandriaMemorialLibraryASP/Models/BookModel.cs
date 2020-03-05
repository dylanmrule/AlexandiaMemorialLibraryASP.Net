using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlexandriaMemorialLibraryASP.Models
{
    //Defined book statuses for the book object
    public enum Status
    {
        OnShelf,
        CheckedOut,
        Processing,
        Unavailable
    }
    //Defined book genres for the book object
    public enum Genre
    {
        Fantasy,
        SciFi,
        Mystery,
        Thriller,
        Travel,
        Adventure,
        GraphicNovel,
        Biography,
        SelfHelp
    }
    public class BookModel
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public ulong ISBN { get; set; }
        public List<Genre> Genre = new List<Genre>();
        public Status Status {get; set;}
        public DateTime DueDate { get; set; }
        public BookModel()
        {

        }
        public BookModel(string title, string author, ulong isbn, Status status, List<Genre> genres)
        {
            this.Title = title;
            this.Author = author;
            this.ISBN = isbn;
            this.Genre = genres;
            this.Status = status;
            this.DueDate = new DateTime(1800, 1, 1);
        }

        public BookModel(string title, string author, ulong isbn, Status status, List<Genre> genre, DateTime dueDate)
        {
            this.Title = title;
            this.Author = author;
            this.ISBN = isbn;
            this.Genre = genre;
            this.Status = status;
            this.DueDate = dueDate;
        }
        public void CheckOut()
        {
            this.Status = Status.CheckedOut;
            this.DueDate = DateTime.Now.AddDays(14);
        }
        public void Return()
        {
            this.Status = Status.OnShelf;
            this.DueDate = new DateTime(1800, 1, 1);
        }
        public int CompareTo(BookModel other)
        {
            return Title.CompareTo(other.Title);
        }
    }
}
