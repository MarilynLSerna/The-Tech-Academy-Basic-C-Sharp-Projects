using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of integers
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

        // Ask the user for a number to divide each number in the list by
        Console.WriteLine("Please enter a number to divide each number in the list by:");

        try
        {
            // Read and convert user input to an integer
            int divisor = Convert.ToInt32(Console.ReadLine());

            // Loop through each number in the list and divide by the user-provided divisor
            foreach (int number in numbers)
            {
                // Perform the division and display the result
                Console.WriteLine($"{number} divided by {divisor} equals {number / divisor}");
            }
        }
        catch (FormatException) // Handles cases where input is not a number
        {
            Console.WriteLine("Error: Please enter a valid number.");
        }
        catch (DivideByZeroException) // Handles division by zero errors
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        catch (Exception ex) // Handles any other unexpected errors
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
        finally
        {
            // Display a message indicating the program has exited the try/catch block
            Console.WriteLine("Exiting the try/catch block.");
        }

        // Inform the user that the program has continued past the try/catch block
        Console.WriteLine("Program has continued execution after the error handling.");

        
        Console.ReadLine();
    }
}