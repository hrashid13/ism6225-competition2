namespace Competition_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Initialize the Library
            Library usfLibrary = new Library();

            //Create the Book objects
            Book book1 = new Book("The Art of Data Strategy", "Liam Reynolds", "ISBN111", 4);
            Book book2 = new Book("Business Insights with AI", "Olivia Carter", "ISBN222", 3);
            Book book3 = new Book("Analytics in Action", "Nathan Brooks", "ISBN333", 6);

            //Add books to the library collection
            usfLibrary.AddBook(book1);
            usfLibrary.AddBook(book2);
            usfLibrary.AddBook(book3);

            //Create the Patron objects (which is using base Person collection in Library)
            Student student1 = new Student("Akhil", "akhil@usf.edu", "S001", "Business Analytics", 2026);
            Student student2 = new Student("Sandeep", "sandeep@usf.edu", "S002", "Information Systems", 2025);
            Staff staff1 = new Staff("Grandon Gill", "grandon@usf.edu", "ST001", "Librarian", "Library Services");

            //Add patrons to the library collection
            usfLibrary.AddPatron(student1);
            usfLibrary.AddPatron(student2);
            usfLibrary.AddPatron(staff1);

            //Display Initial Status
            Console.WriteLine("Books in Library:");
            usfLibrary.DisplayBooks();
            
            Console.WriteLine(); //Blank line for exact formatting match

            Console.WriteLine("Patrons in Library:");
            usfLibrary.DisplayPatrons();
            
            Console.WriteLine(); // Blank line for exact formatting match

            // Execute Borrowing Scenario
            Console.WriteLine("Borrowing Books...");
            
            // Call the BorrowBook method to deduct the available copies
            book2.BorrowBook(); 
            Console.WriteLine("Sandeep borrowed 'Business Insights with AI'");

            book3.BorrowBook();
            Console.WriteLine("Akhil borrowed 'Analytics in Action'");
            
            Console.WriteLine(); // Blank line for exact formatting match

            // Display Final Status
            Console.WriteLine("Books after borrowing:");
            Console.WriteLine("Books in Library:");
            usfLibrary.DisplayBooks();
        }
    }
}
