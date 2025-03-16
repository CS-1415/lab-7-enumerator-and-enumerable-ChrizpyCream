using System;
using System.Collections.Generic;
using Lab06; 


class Program
{
    static void Main()
    {
        
        Console.WriteLine("This is a Doubly Linked List maker. You can add items at the beginning or end of the list and you can display the current contents of the list");

        // Initialize an instance of a doubly linked list to store string values
        DoublyLinkedList<string> list = new(null, null, 0); // Ensure the constructor matches the implementation in Lab06
        bool IsPPressed = false; // Flag to track if the user wants to exit


        // Main loop to keep the program running until the user chooses to exit
        while (!IsPPressed)
        {
            // Prompt user for input
            Console.WriteLine("\nWould you like to add to the beginning, the end, or view contents? (Type beginning, end, view, or p to exit)");
            string input = Console.ReadLine();
            string temp = validInput(input); // Validate user input


            // Process user input using a switch statement
            switch (temp)
            {
                case "beginning":
                    // Prompt user to enter a string to add to the beginning
                    Console.WriteLine("Input what string you would like to store.");
                    string firstInput = Console.ReadLine();
                    if (!string.IsNullOrEmpty(firstInput)) // Ensure input is not null or empty
                        list.AddFirst(firstInput); // Add the string to the beginning of the list
                    break;


                case "end":
                    // Prompt user to enter a string to add to the end
                    Console.WriteLine("Input what string you would like to store.");
                    string lastInput = Console.ReadLine();
                    if (!string.IsNullOrEmpty(lastInput)) // Ensure input is not null or empty
                        list.AddLast(lastInput); // Add the string to the end of the list
                    break;


                case "view":
                    // Display all elements in the linked list
                    foreach (var node in list)
                    {
                        Console.Write($"{node}, ");
                    }
                    Console.WriteLine(); // Print a new line after displaying the list contents
                    break;


                case "p":
                    // Exit the loop if the user enters 'p'
                    IsPPressed = true;
                    break;
            }
        }
        // exit the program
        Environment.Exit(0);
    }


   
    static string validInput(string tempString)
    {
        // Check if input matches one of the allowed commands
        if (tempString == "beginning" || tempString == "end" || tempString == "view" || tempString == "p")
        {
            return tempString; // Return valid input
        }
        else
        {
            // Notify user of invalid input and prompt again
            Console.WriteLine("Invalid Input. Try Again.");
            string retryInput = Console.ReadLine();
            return retryInput != null ? validInput(retryInput) : "p"; // If input is null, default to 'p' (exit)
        }
    }
}
