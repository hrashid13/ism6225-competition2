using System;
using System.Collections.Generic;
using System.Text;

namespace Competition_2
{
    public class Library
    {
       public List<Book> Books { get; set; } = new List<Book>();
    public List<Person> Patrons { get; set; } = new List<Person>();

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public void AddPatron(Person person)
    {
        Patrons.Add(person);
    }

    public void DisplayBooks()
    {
        Console.WriteLine("Books in Library:");
        foreach (var book in Books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Available Copies: {book.AvailableCopies}");
        }
        Console.WriteLine();
    }

    public void DisplayPatrons()
    {
        Console.WriteLine("Patrons in Library:");
        foreach (var p in Patrons)
        {
            Console.WriteLine($"Name: {p.Name}, ID: {p.ID}");
        }
        Console.WriteLine();
    }

    public void BorrowBook(string title, string borrowerName)
    {
        var book = Books.Find(b => b.Title == title);

        if (book != null && book.AvailableCopies > 0)
        {
            book.BorrowBook();
            Console.WriteLine($"{borrowerName} borrowed '{title}'");
        }
        else
        {
            Console.WriteLine($"Book '{title}' not available.");
        }
    }
    }
}
