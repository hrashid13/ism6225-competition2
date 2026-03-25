using System;
using System.Collections.Generic;
using System.Text;

namespace Competition_2
{
    public class Book
    {
           public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public int AvailableCopies { get; set; }

    public Book(string title, string author, string isbn, int copies)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        AvailableCopies = copies;
    }

    public void BorrowBook()
    {
        if (AvailableCopies > 0)
        {
            AvailableCopies--;
        }
        else
        {
            Console.WriteLine($"'{Title}' is not available.");
        }
    }
    }
}
