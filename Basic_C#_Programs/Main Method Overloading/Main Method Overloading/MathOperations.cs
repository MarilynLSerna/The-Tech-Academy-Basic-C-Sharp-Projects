using System;

namespace MainMethodApp
{
    // Create the MathOperations class containing three overloaded methods
    public class MathOperations
    {
        // Method 1: Takes an integer and adds 5, then returns the result
        public int PerformOperation(int number)
        {
            return number + 5; 
        }

        // Method 2: Takes a decimal and subtracts 2.5, then returns the result as an integer
        public int PerformOperation(decimal number)
        {
            return (int)(number - 2.5m); 
        }

        // Method 3: Takes a string, converts it to an integer if possible, multiplies by 10, and returns the result
        public int PerformOperation(string number)
        {
            int convertedNumber;

            // Try to convert the string to an integer
            if (int.TryParse(number, out convertedNumber))
            {
                return convertedNumber * 10; 
            }
            else
            {
                // If the conversion fails, return 0 as a default value
                Console.WriteLine("Invalid input. Returning 0 as default.");
                return 0;
            }
        }
    }
}