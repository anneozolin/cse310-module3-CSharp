using AnnesLibrary.Classes;
using System;

namespace AnnesLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:/Users/aneli/Desktop/BYU/CSE310/Portifolio/cse310-module3-CSharp/AnnesLibrary/Data/LibraryData.txt";
            Library library = new Library();

            // Load books from file
            var books = FileManager.LoadFromFile(filePath);
            foreach (var book in books)
            {
                library.AddBook(book);
            }

            User user = new User(library);
            bool exit = false;

            while (!exit)
            {
                // Check if the console can be cleared (i.e., not redirected)
                if (!Console.IsInputRedirected && !Console.IsOutputRedirected)
                {
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("\nWelcome to AnnesLibrary!");
                }

                Console.WriteLine("1. View Books");
                Console.WriteLine("2. Borrow a Book");
                Console.WriteLine("3. Return a Book");
                Console.WriteLine("4. Add a New Book");
                Console.WriteLine("5. Save & Exit");
                Console.Write("Choose an option: ");
                
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        // View books
                        user.ViewBooks();
                        break;

                    case "2":
                        // Borrow a book
                        user.BorrowBook();
                        break;

                    case "3":
                        // Return a book
                        user.ReturnBook();
                        break;

                    case "4":
                        // Add a new book
                        user.AddNewBook();
                        break;

                    case "5":
                        // Save & exit
                        Console.WriteLine("Saving data...");
                        FileManager.SaveToFile(filePath, library.GetBooks());
                        Console.WriteLine("Data saved successfully. Exiting...");
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                // Pause and wait for the user to press Enter to continue
                if (choice != "5")
                {
                    Console.WriteLine("\nPress Enter to continue...");
                    Console.ReadLine();
                }
            }
        }
    }
}
