using BookStoreApplication.Models;

namespace BookStoreApplication
{
    public class BookStore
    {
        private List<Book> books = new List<Book>();

        public void Add(string title, string description, int amount)
        {
            var bookExists = books.Any(book => book.Title == title);

            if (bookExists)
            {
                throw new ArgumentException("Book already exists");
            }

            var book = new Book(title, description, amount);
      
            books.Add(book);
        }

        public List<Book> GetAll()
        {
            return books;
        }

        public void Delete(string title)
        {
            books.RemoveAll(book => book.Title == title);
        }
    }
}
