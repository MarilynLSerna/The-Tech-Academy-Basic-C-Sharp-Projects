using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // One-dimensional array of strings
        string[] stringArray = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

        // Ask the user to select an index of the string array
        Console.WriteLine("Select an index (0-4) to display a fruit from the array:");
        int stringIndex;

        // Check if the user's input is valid
        if (int.TryParse(Console.ReadLine(), out stringIndex) && stringIndex >= 0 && stringIndex < stringArray.Length)
        {
            // Display the string at the selected index
            Console.WriteLine("You selected: " + stringArray[stringIndex]);
        }
        else
        {
            // Display an error message for invalid index selection
            Console.WriteLine("Invalid index! Please select an index between 0 and 4.");
        }

        // One-dimensional array of integers
        int[] intArray = { 10, 20, 30, 40, 50 };

        // Ask the user to select an index of the integer array
        Console.WriteLine("\nSelect an index (0-4) to display a number from the array:");
        int intIndex;

        // Check if the user's input is valid
        if (int.TryParse(Console.ReadLine(), out intIndex) && intIndex >= 0 && intIndex < intArray.Length)
        {
            // Display the integer at the selected index
            Console.WriteLine("You selected: " + intArray[intIndex]);
        }
        else
        {
            // Display an error message for invalid index selection
            Console.WriteLine("Invalid index! Please select an index between 0 and 4.");
        }

        // List of strings
        List<string> stringList = new List<string> { "Dog", "Cat", "Horse", "Rabbit", "Elephant" };

        // Ask the user to select an index of the list
        Console.WriteLine("\nSelect an index (0-4) to display an animal from the list:");
        int listIndex;

        // Check if the user's input is valid
        if (int.TryParse(Console.ReadLine(), out listIndex) && listIndex >= 0 && listIndex < stringList.Count)
        {
            // Display the string at the selected index
            Console.WriteLine("You selected: " + stringList[listIndex]);
        }
        else
        {
            // Display an error message for invalid index selection
            Console.WriteLine("Invalid index! Please select an index between 0 and 4.");
        }

        
        Console.ReadLine();
    }
}
