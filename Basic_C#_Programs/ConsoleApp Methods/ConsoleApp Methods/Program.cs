using System;

namespace CallingMethodsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // PART 1: Instantiate the MathOperations class to access its methods.
            MathOperations mathOps = new MathOperations();

            // PART 2: Ask the user to input a number to perform math operations on.
            Console.WriteLine("Please enter an integer number to perform math operations on:");
            int userNumber;

            // Try to convert the user input to an integer and check if it’s valid.
            while (!int.TryParse(Console.ReadLine(), out userNumber))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer number:");
            }

            // PART 3: Call each method in turn and display the results.

            // Call the AddTen method and display the result.
            int addTenResult = mathOps.AddTen(userNumber);
            Console.WriteLine($"Result of adding 10 to {userNumber} is: {addTenResult}");

            // Call the MultiplyByFive method and display the result.
            int multiplyResult = mathOps.MultiplyByFive(userNumber);
            Console.WriteLine($"Result of multiplying {userNumber} by 5 is: {multiplyResult}");

            // Call the SubtractSeven method and display the result.
            int subtractResult = mathOps.SubtractSeven(userNumber);
            Console.WriteLine($"Result of subtracting 7 from {userNumber} is: {subtractResult}");

            // Pause the console to keep it open and view the results before it closes.
            Console.ReadLine();
        }
    }
}