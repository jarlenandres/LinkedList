using DoubleList;

var list = new DoubleLinkedList<string>();
var opc = string.Empty;

do
{
    opc = Menu();
    switch (opc)
    {
        case "0":
            Console.WriteLine("See you next time...");
            break;
        case "1":
            Console.Write("Enter the value: ");
            var dataAtBeginning = Console.ReadLine()!;
            if (dataAtBeginning != null)
            { 
                list.InsertAtBeginning(dataAtBeginning);
            }
            break;
        case "2":
            Console.Write("Enter the value: ");
            var dataAtEnd = Console.ReadLine()!;
            if (dataAtEnd != null)
            { 
                list.InsertAtEnd(dataAtEnd);
            }
            break;
        case "3":
            Console.WriteLine(list.GetForward());
            break;
        case "4":
            Console.WriteLine(list.GetBackward());
            break;
        case "5":
            Console.Write("Enter the data to remove: ");
            var remove = Console.ReadLine()!;
            if (remove != null)
            { 
                list.Remove(remove);
                Console.WriteLine("Item removed.");
            }
            break;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }

} while (opc != "0");

string Menu()
{
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("1. Insert at biginning.");
    Console.WriteLine("2. Insert at end.");
    Console.WriteLine("3. Print the list Forward.");
    Console.WriteLine("4. Print the list Backward.");
    Console.WriteLine("5. Remove.");
    Console.WriteLine("0. Exit.");
    Console.Write("Enter your option: ");
    return Console.ReadLine()!;
}