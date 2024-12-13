namespace AnnesLibrary.Classes
{
    public class User
    {
        private Library library;

        public User(Library library)
        {
            this.library = library;
        }

        public void ViewBooks()
        {
            library.DisplayBooks();
        }

        public void BorrowBook()
        {
            Console.Write("Enter the title of the book you want to borrow: ");
            string borrowTitle = Console.ReadLine();
            var book = library.GetBooks().Find(b => b.Title.Equals(borrowTitle, StringComparison.OrdinalIgnoreCase));
            if (book != null)
            {
                book.Borrow();
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        public void ReturnBook()
        {
            Console.Write("Enter the title of the book you want to return: ");
            string returnTitle = Console.ReadLine();
            var book = library.GetBooks().Find(b => b.Title.Equals(returnTitle, StringComparison.OrdinalIgnoreCase));
            if (book != null)
            {
                book.Return();
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        public void AddNewBook()
        {
            Console.Write("Enter the title of the new book: ");
            string title = Console.ReadLine();
            Console.Write("Enter the author of the new book: ");
            string author = Console.ReadLine();
            Console.Write("Enter the ISBN of the new book: ");
            string isbn = Console.ReadLine();

            var book = new Book(title, author, isbn);
            library.AddBook(book);
            Console.WriteLine($"'{title}' has been added to the library.");
        }
    }
}
