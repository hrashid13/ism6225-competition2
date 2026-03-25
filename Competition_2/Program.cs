using System;
using System.Collections.Generic;
using System.Text;

namespace Competition_2
{
    class Program
    {
         static void Main(string[] args)
    {
        Library library = new Library();

        // Books
        var b1 = new Book("The Art of Data Strategy", "Liam Reynolds", "ISBN111", 4);
        var b2 = new Book("Business Insights with AI", "Olivia Carter", "ISBN222", 3);
        var b3 = new Book("Analytics in Action", "Nathan Brooks", "ISBN333", 6);

        library.AddBook(b1);
        library.AddBook(b2);
        library.AddBook(b3);

        // Students
        var s1 = new Student("Akhil", "akhil@usf.edu", "S001", "Business Analytics", 2026);
        var s2 = new Student("Sandeep", "sandeep@usf.edu", "S002", "Information Systems", 2025);

        // Staff
        var staff = new Staff("Grandon Gill", "grandon@usf.edu", "ST001", "Librarian", "Library Services");

        library.AddPatron(s1);
        library.AddPatron(s2);
        library.AddPatron(staff);

        // BEFORE borrowing
        library.DisplayBooks();
        library.DisplayPatrons();

        // Borrow scenario
        Console.WriteLine("Borrowing Books...");
        library.BorrowBook("Business Insights with AI", "Sandeep");
        library.BorrowBook("Analytics in Action", "Akhil");

        Console.WriteLine();

        // AFTER borrowing
        Console.WriteLine("Books after borrowing:");
        library.DisplayBooks();
    }
    }
}
