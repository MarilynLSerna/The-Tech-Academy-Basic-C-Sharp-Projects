using System;
using System.Collections.Generic; // Required for using the List class

class Program
{
    static void Main(string[] args)
    {
        // PART 1: Create a one-dimensional array of strings.
        string[] items = { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5" };

        // PART 1: Ask the user to input some text to append to each item in the array.
        Console.WriteLine("Please enter a description to add to each item in the list:");
        string userInput = Console.ReadLine(); 

        // PART 1: Use a loop to iterate through each string in the array and add the user's text.
        for (int i = 0; i < items.Length; i++)
        {
            items[i] += " - " + userInput; 
        }

        // PART 2: Create an intentional infinite loop for this part of the assignment.
        int counter = 0; // Initialize aariable for the loop. counter v
        while (true) // Start of the infinite loop.
        {
            Console.WriteLine("Counter value in the infinite loop: " + counter);
            counter++; 

            // PART 2: Fix the infinite loop by adding a break statement when the counter reaches 5.
            if (counter >= 5)
            {
                Console.WriteLine("Infinite loop has been fixed. Exiting the loop.");
                break; 
            }
        }

        // PART 3: Create a loop that uses the "<" comparison operator.
        Console.WriteLine("\nLoop using the '<' operator:");
        for (int i = 0; i < items.Length; i++) // This loop uses "<" to continue iterating while i is less than the length of the array.
        {
            Console.WriteLine("Item at index " + i + ": " + items[i]); 
        }

        // PART 3: Create another loop that uses the "<=" comparison operator.
        Console.WriteLine("\nLoop using the '<=' operator:");
        int index = 0;
        while (index <= items.Length - 1) // This loop uses "<=" to continue iterating while index is less than or equal to the last index of the array.
        {
            Console.WriteLine("Item at index " + index + ": " + items[index]); 
            index++; 
        }

        // PART 4: Create a list of strings where each item is unique.
        List<string> itemList = new List<string> { "Red", "Green", "Blue", "Yellow", "Purple" };

        // PART 4: Ask the user to input text to search for in the list.
        Console.WriteLine("\nPlease enter a color to search for in the list:");
        string searchInput = Console.ReadLine(); 

        // PART 4: Create a loop that iterates through the list and displays the index of the matching text.
        bool isFound = false; // Flag to indicate if a match is found.
        for (int i = 0; i < itemList.Count; i++)
        {
            if (itemList[i].Equals(searchInput, StringComparison.OrdinalIgnoreCase)) // Check for match (case insensitive)
            {
                Console.WriteLine("The color \"" + searchInput + "\" is found at index: " + i);
                isFound = true; // Set flag to true if match is found
                break; // Stop the loop once a match is found
            }
        }

        // PART 4: Check if the user's input was not found in the list and display a message.
        if (!isFound)
        {
            Console.WriteLine("The color \"" + searchInput + "\" is not on the list.");
        }

        // PART 5: Create a list of strings with duplicate items.
        List<string> colorList = new List<string> { "Red", "Blue", "Red", "Green", "Yellow", "Blue" };

        // PART 5: Ask the user to input text to search for in the list with duplicates.
        Console.WriteLine("\nPlease enter a color to search for in the list with duplicates:");
        string duplicateSearchInput = Console.ReadLine(); // Read the user's input for search.

        // PART 5: Create a loop that iterates through the list and displays the indices of all matching items.
        bool duplicateFound = false; // Flag to check if any match is found.
        for (int i = 0; i < colorList.Count; i++)
        {
            if (colorList[i].Equals(duplicateSearchInput, StringComparison.OrdinalIgnoreCase)) // Check for matches (case insensitive)
            {
                Console.WriteLine("The color \"" + duplicateSearchInput + "\" is found at index: " + i);
                duplicateFound = true; // Set flag to true if at least one match is found
            }
        }

        // PART 5: Check if no matches were found and display a message.
        if (!duplicateFound)
        {
            Console.WriteLine("The color \"" + duplicateSearchInput + "\" is not on the list with duplicates.");
        }

        // PART 6: Create a list of strings with at least two identical items.
        List<string> duplicateList = new List<string> { "A", "B", "C", "D", "C", "E", "A" };

        // PART 6: Create a HashSet to track already seen items.
        HashSet<string> seenItems = new HashSet<string>();

        // PART 6: Use a foreach loop to evaluate each item in the list.
        Console.WriteLine("\nEvaluating items in the duplicate list:");
        foreach (string item in duplicateList)
        {
            // Check if the item has already been seen
            if (seenItems.Contains(item))
            {
                Console.WriteLine(item + " - this item is a duplicate");
            }
            else
            {
                Console.WriteLine(item + " - this item is unique");
                seenItems.Add(item); // Add the item to the HashSet to mark it as seen
            }
        }

        // PART 1: Create a second loop to print each string in the array one at a time.
        Console.WriteLine("\nThe final updated items in the array are:");
        foreach (string item in items)
        {
            Console.WriteLine(item);
        }

        
        Console.ReadLine();
    }
}