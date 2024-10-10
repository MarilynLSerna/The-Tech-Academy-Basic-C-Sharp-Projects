using System;

namespace ClassSubmissionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to input an integer number.
            Console.WriteLine("Please enter an integer number:");
            int userInput;

            // Validate user input and convert to an integer.
            while (!int.TryParse(Console.ReadLine(), out userInput))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer number:");
            }

            // Call the DivideByTwo method with the user's input and display the result.
            MathOperations.DivideByTwo(userInput, out int dividedResult);
            Console.WriteLine($"The result of dividing {userInput} by 2 is: {dividedResult}");

            // Call the DivideByTwo method overload with a double value.
            MathOperations.DivideByTwo(15.5, out double dividedDoubleResult);
            Console.WriteLine($"The result of dividing 15.5 by 2 is: {dividedDoubleResult}");

            // Call the SquareNumber method to demonstrate an additional output parameter.
            MathOperations.SquareNumber(userInput, out int squaredResult);
            Console.WriteLine($"The square of {userInput} is: {squaredResult}");

            
            Console.ReadLine();
        }
    }
}
