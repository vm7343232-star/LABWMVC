using Microsoft.AspNetCore.Mvc;
using DigitalLibrary.Models;
namespace DigitalLibrary.Controllers
{public class BooksController : Controller
    {private static List<Author> authors = new List<Author>
        {
            new Author { Id = 1, Name = "J.K. Rowling" },
            new Author { Id = 2, Name = "George Orwell" },
            new Author { Id = 3, Name = "Adam Mickiewicz" }
        };
        private static List<Book> books = new List<Book>
        {
            new Book
            {
                Id = 1,
                Title = "Titanic",
                AuthorId = 1,
                PublicationYear = 1997,
                Author = new Author { Id = 1, Name = "Stanisław Lem" }
            },
            new Book
            {
                Id = 2,
                Title = "1984",
                AuthorId = 2,
                PublicationYear = 1949,
                Author = new Author { Id = 2, Name = "George Orwell" }
            }
        };

        public IActionResult Index()
        {
            return View(books);
        }
        public IActionResult Search(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
                return View("Index", books);

            var result = books.Where(b =>
                b.Title.ToLower().Contains(query.ToLower()) ||
                (b.Author != null && b.Author.Name.ToLower().Contains(query.ToLower()))
            ).ToList();

            return View("Index", result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Authors = authors;
            return View();
        }
        [HttpPost]
        public IActionResult Create(string title, int authorId, int publicationYear)
        {
            var author = authors.FirstOrDefault(a => a.Id == authorId);

            var newBook = new Book
            {
                Id = books.Count > 0 ? books.Max(b => b.Id) + 1 : 1,
                Title = title,
                AuthorId = authorId,
                PublicationYear = publicationYear,
                Author = author
            };

            books.Add(newBook);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Authors = authors;

            var book = books.FirstOrDefault(b => b.Id == id);
            return View(book);
        }
        [HttpPost]
        public IActionResult Edit(int id, string title, int authorId, int publicationYear)
        {
            var book = books.FirstOrDefault(b => b.Id == id);

            if (book != null)
            {
                book.Title = title;
                book.AuthorId = authorId;
                book.PublicationYear = publicationYear;
                book.Author = authors.FirstOrDefault(a => a.Id == authorId);
            }

            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);

            if (book != null)
                books.Remove(book);

            return RedirectToAction("Index");
        }
    }
}