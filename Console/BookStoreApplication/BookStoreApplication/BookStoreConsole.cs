

namespace BookStoreApplication
{
    public class BookStoreConsole
    {
        private BookStore _bookStore {  get; set; } = new BookStore();

        public void ExecuteAdd()
        {
            try
            {
                
                Console.WriteLine("Write book title");
                var title = Console.ReadLine();

                Console.WriteLine("Write book description");
                var description = Console.ReadLine();

                Console.WriteLine("Write book anount");
                var amount = Convert.ToInt32(Console.ReadLine());

                _bookStore.Add(title, description, amount);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something bad has happened, please try again");
            }
        }

        public void ExecuteList()
        {
            var books = _bookStore.GetAll();

            foreach (var book in books)
            {
                Console.WriteLine(
                    $" Title: {book.Title}\n " +
                    $"Description: {book.Description}\n " +
                    $"Amount: {book.Amount}"
                );
            }
        }

        public void ExecuteDelete()
        {
            Console.WriteLine("Please enter the title of the book you want to remove");
            var title = Console.ReadLine();
            _bookStore.Delete(title);
        }
    }
}
