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
            list.InsertAtBeginning(Console.ReadLine()!);
            break;
        case "2":
            Console.Write("Enter the value: ");
            list.InsertAtEnd(Console.ReadLine()!);
            break;
        case "3":
            Console.WriteLine(list.GetForward());
            break;
        case "4":
            Console.WriteLine(list.GetBackward());
            break;
        //case "4":
        //    Console.Write("Enter the value: ");
        //    Console.Write($"The result is {list.Contains(Console.ReadLine()!)}");
        //    break;
        //case "5":
        //    list.Remove(Console.ReadLine()!);
        //    break;
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
    Console.WriteLine("5. Search in the list.");
    Console.WriteLine("6. Remove the first in the list.");
    Console.WriteLine("0. Exit.");
    Console.Write("Enter your option: ");
    return Console.ReadLine()!;
}