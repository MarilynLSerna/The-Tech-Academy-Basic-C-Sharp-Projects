using System;

namespace OptionalParameterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // PART 1: Instantiate the MathOperations class to access its methods.
            MathOperations mathOps = new MathOperations();

            // PART 2: Ask the user to input the first number.
            Console.WriteLine("Please enter the first number:");
            int firstNumber;
            while (!int.TryParse(Console.ReadLine(), out firstNumber))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer number:");
            }

            // PART 3: Ask the user to input the second number (optional).
            Console.WriteLine("Please enter the second number (or press Enter to skip):");
            string secondInput = Console.ReadLine(); // Read the second input as a string

            // PART 4: Initialize secondNumber to 0 if no input is provided, otherwise convert to integer.
            int secondNumber;
            if (string.IsNullOrEmpty(secondInput))
            {
                secondNumber = 0; // No input means second number is set to 0 (optional parameter default).
            }
            else
            {
                while (!int.TryParse(secondInput, out secondNumber))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer number or press Enter to skip:");
                    secondInput = Console.ReadLine(); // Prompt again for valid input
                }
            }

            // PART 5: Call the AddNumbers method in the MathOperations class, passing one or both numbers.
            int result;
            if (secondNumber == 0) // If the second number is 0, call the method with only the first number.
            {
                result = mathOps.AddNumbers(firstNumber);
                Console.WriteLine($"Result of adding {firstNumber} with the default value of 0 is: {result}");
            }
            else // If the second number is provided, call the method with both numbers.
            {
                result = mathOps.AddNumbers(firstNumber, secondNumber);
                Console.WriteLine($"Result of adding {firstNumber} and {secondNumber} is: {result}");
            }

            
            Console.ReadLine();
        }
    }
}