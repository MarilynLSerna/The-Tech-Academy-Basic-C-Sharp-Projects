using System;

namespace MethodClassApp
{
    // Create a MathOperations class with a void method that accepts two integers as parameters.
    public class MathOperations
    {
        // Method that takes two integers, performs a math operation on the first, and displays the second.
        public void ProcessNumbers(int num1, int num2)
        {
            // Perform a math operation (e.g., multiply the first number by 2)
            int result = num1 * 2;

            // Display the result of the math operation and the value of the second parameter
            Console.WriteLine($"The result of multiplying {num1} by 2 is: {result}");
            Console.WriteLine($"The value of the second parameter is: {num2}");
        }
    }
}
