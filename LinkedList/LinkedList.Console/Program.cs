using LinkedList.Core;
using System.ComponentModel.Design;

var list = new SinglyLinkedList<string>();
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
            list.PrintList();
            break;
        case "4":
            Console.Write("Enter the value: ");
            Console.Write($"The result is {list.Contains(Console.ReadLine()!)}");
            break;
        case "5":
            Console.Write("Enter the value: ");
            list.Remove(Console.ReadLine()!);
            break;
        case "6":
            list.Reverse();
            Console.WriteLine("List reversed.");
            break;
        case "7":
            list.ClearList();
            Console.WriteLine("List cleaned.");
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
    Console.WriteLine("3. Print list.");
    Console.WriteLine("4. Search.");
    Console.WriteLine("5. Remove item.");
    Console.WriteLine("6. Reverse.");
    Console.WriteLine("7. Clear all list.");
    Console.WriteLine("0. Exit.");
    Console.Write("Enter your option: ");
    return Console.ReadLine()!;
}