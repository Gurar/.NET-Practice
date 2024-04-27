// See https://aka.ms/new-console-template for more information


using BookStoreApplication;

var bookStoreConsole = new BookStoreConsole();

while (true)
{
    Console.WriteLine("Please enter the command: 'Add', 'Exit', 'List', 'Delete' ");
    
    var command = Console.ReadLine();

    switch (command)
    {
        case "Exit":
            break;
        case "Add":
            bookStoreConsole.ExecuteAdd();
            break;
        case "Delete":
            bookStoreConsole.ExecuteDelete();
            break;
        case "List":
            bookStoreConsole.ExecuteList();
            break;
        default:
            Console.WriteLine("Command was not recognised, please try again");
            break;
    }
}
