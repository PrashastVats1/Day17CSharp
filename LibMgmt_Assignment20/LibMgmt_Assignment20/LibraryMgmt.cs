using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMgmt_Assignment20
{
    public class LibraryMgmt
    {
        List<Book> books;
        public LibraryMgmt()
        {
            books = new List<Book>()
            {
                new Book { BookId = 1, Title = "Sherlock Holmes", Author = "Arthur Conan Doyle", Genre = "Mystery", IsAvailable=true},
                new Book { BookId = 2, Title = "Panchatantra", Author = "Vishnu Sharma", Genre = "Fables", IsAvailable=true },
                new Book { BookId = 3, Title = "Inferno", Author = "Dan Brown", Genre = "Thriller", IsAvailable=true },
                new Book { BookId = 4, Title = "One Piece", Author = "Eichiri Oda", Genre = "Shonen, Fantasy", IsAvailable=true },
                new Book { BookId = 5, Title = "Everyone Else Is A Returnee", Author = "Toika", Genre = "Comedy, Adventure", IsAvailable=true},
                new Book { BookId = 6, Title = "Naruto", Author = "Masashi Kishimoto", Genre = "Shonen, Adventure", IsAvailable=true }
            };
        }
        public void AddBook(Book book)
        {
            books.Add(book);
            this.ViewAllBooks();
        }
        public void ViewAllBooks()
        {
            foreach(Book book in books)
            {
                Console.WriteLine($"Book ID: \t{book.BookId}");
                Console.WriteLine($"Book Title: \t{book.Title}");
                Console.WriteLine($"Book Author: \t{book.Author}");
                Console.WriteLine($"Book Genre: \t{book.Genre}");
                Console.WriteLine($"Book is available: \t{book.IsAvailable}");
                Console.WriteLine();
            }
        }
        public void SearchBookById(int bookId)
        {
            var book = books.Find(b => b.BookId == bookId);
            if (book != null)
            {
                Console.WriteLine($"Book ID: \t{book.BookId}");
                Console.WriteLine($"Book Title: \t{book.Title}");
                Console.WriteLine($"Book Author: \t{book.Author}");
                Console.WriteLine($"Book Genre: \t{book.Genre}");
                Console.WriteLine($"Book is available: \t{book.IsAvailable}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Book Not Found");
            }
        }
        public void SearchBookByTitle(string title)
        {
            var book = books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if(book != null)
            {
                Console.WriteLine($"Book ID: \t{book.BookId}");
                Console.WriteLine($"Book Title: \t{book.Title}");
                Console.WriteLine($"Book Author: \t{book.Author}");
                Console.WriteLine($"Book Genre: \t{book.Genre}");
                Console.WriteLine($"Book is available: \t{book.IsAvailable}");
            }
            else
            {
                Console.WriteLine("Book Not Found");
            }
        }
    }
}
