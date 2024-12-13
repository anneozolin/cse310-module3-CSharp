using System.IO;

namespace AnnesLibrary.Classes
{
    public class FileManager
    {
        public static void SaveToFile(string filePath, List<Book> books)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var book in books)
                {
                    writer.WriteLine($"{book.Title},{book.Author},{book.ISBN},{book.IsAvailable}");
                }
            }
        }

        public static List<Book> LoadFromFile(string filePath)
        {
            List<Book> books = new List<Book>();

            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var parts = line.Split(',');
                        var book = new Book(parts[0], parts[1], parts[2])
                        {
                            IsAvailable = bool.Parse(parts[3])
                        };
                        books.Add(book);
                    }
                }
            }

            return books;
        }
    }
}
