

using BookStoreApplication.Models;

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
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Something bad has happened, please try again");
            }
        }

        public void ExecuteUpdate()
        {

            try
            {
                Console.WriteLine("Write book title");
                var title = Console.ReadLine();

                var updateBook = _bookStore.GetAll().SingleOrDefault(book => book.Title == title);

                if (updateBook != null)
                {
                    Console.WriteLine("Write book title");
                    var updateTitle = Console.ReadLine();

                    if (updateTitle.Length == 0)
                    {
                        updateTitle = title;
                    }

                    Console.WriteLine("Write book description");
                    var updateDescription = Console.ReadLine();

                    if (updateDescription.Length == 0)
                    {
                        updateDescription = updateBook.Description;
                    }

                    Console.WriteLine("Write book anount");
                    var updateAmount = Convert.ToInt32(Console.ReadLine());

                    if (updateAmount <= 0)
                    {
                        updateAmount = updateBook.Amount;
                    }

                    var updateBookInfo = new Book(updateTitle, updateDescription, updateAmount);

                    _bookStore.Update(updateBook, updateBookInfo);


                }
                else
                {
                    Console.WriteLine("Book what you want update not found");
                }


            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Something bad has happened, please try again");
            }

            
            

            //var updateBook = new Book (title, description, amount );

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
