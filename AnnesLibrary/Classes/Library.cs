namespace AnnesLibrary.Classes
{
    public class Library
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public List<Book> GetBooks()
        {
            return books;
        }

        public void DisplayBooks()
        {
            Console.WriteLine("List of available books:");
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title} by {book.Author} - Available: {book.IsAvailable}");
            }
        }
    }
}
