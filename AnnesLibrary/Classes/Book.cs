namespace AnnesLibrary.Classes
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool IsAvailable { get; set; }

        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            IsAvailable = true;
        }

        public void Borrow()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine($"'{Title}' has been borrowed.");
            }
            else
            {
                Console.WriteLine($"'{Title}' is not available for borrowing.");
            }
        }

        public void Return()
        {
            IsAvailable = true;
            Console.WriteLine($"'{Title}' has been returned.");
        }
    }
}
