using System;
using System.Collections.Generic;
using System.Text;

namespace Competition_2
{
    internal class Library
    {
        private readonly List<Book> books = new();
        private readonly List<Person> patrons = new();

        public Library()
        {
        }

        public void AddBook(Book book)
        {
            if (book == null) throw new ArgumentNullException(nameof(book));
            books.Add(book);
        }

        public void AddPatron(Person patron)
        {
            if (patron == null) throw new ArgumentNullException(nameof(patron));
            patrons.Add(patron);
        }

        public void DisplayBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books in the library.");
                return;
            }

            Console.WriteLine("Books:");
            foreach (var b in books)
            {
                Console.WriteLine(b?.ToString() ?? "<null>");
            }
        }

        public void DisplayPatrons()
        {
            if (patrons.Count == 0)
            {
                Console.WriteLine("No patrons in the library.");
                return;
            }

            Console.WriteLine("Patrons:");
            foreach (var p in patrons)
            {
                Console.WriteLine(p?.ToString() ?? "<null>");
            }
        }
    }
}
