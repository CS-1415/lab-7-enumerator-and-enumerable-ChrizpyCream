using System.Net;
using System.Reflection;
using Lab06;


Console.WriteLine("This is a Doubly Linked List maker. You can add items at the beginning or end of the list and you can display the current contents of the list");

DoublyLinkedList<string> list = new(null, null, 0);
bool IsPPressed = false;

while (!IsPPressed)
{
    Console.WriteLine("\nWould you like to add to the beginning, the end, or view contents? (Type beginning, end, view, or p to exit)");
    string temp = validInput(Console.ReadLine());
    int i = 0;
    switch (temp)
    {
        case "beginning":
            i++;
            Console.WriteLine("Input what string you would like to store.");
            list.AddFirst(Console.ReadLine());
            break;

        case "end":
            i++;
            Console.WriteLine("Input string  whatyou would like to store.");
            list.AddLast(Console.ReadLine());
            break;

        case "View":
            foreach(var node in list)
            {
                Console.Write($"{node}, ");
            }
            break;

        case "p":
            IsPPressed = true;
            break;
    }
}
Environment.Exit(0);

string validInput(string tempString)
{
    if (tempString == "beginning" || tempString == "end" || tempString == "view" || tempString == "p")
    {
        return tempString;
    }
    else
    {
        Console.WriteLine("Invalid Input Try Again.");
        return validInput(Console.ReadLine());
    }
}