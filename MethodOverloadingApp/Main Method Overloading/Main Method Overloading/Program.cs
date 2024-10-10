using System;

namespace MainMethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // PART 1: Instantiate the MathOperations class to access its methods
            MathOperations mathOps = new MathOperations();

            // PART 2: Call the PerformOperation method with an integer parameter and display the result
            Console.WriteLine("Calling PerformOperation with an integer (10):");
            int intResult = mathOps.PerformOperation(10);
            Console.WriteLine("Result of adding 5 to 10 is: " + intResult);

            // PART 3: Call the PerformOperation method with a decimal parameter and display the result
            Console.WriteLine("\nCalling PerformOperation with a decimal (12.5):");
            int decimalResult = mathOps.PerformOperation(12.5m);
            Console.WriteLine("Result of subtracting 2.5 from 12.5 is: " + decimalResult);

            // PART 4: Call the PerformOperation method with a string parameter and display the result
            Console.WriteLine("\nCalling PerformOperation with a string ('7'):");
            int stringResult = mathOps.PerformOperation("7");
            Console.WriteLine("Result of converting '7' to an integer and multiplying by 10 is: " + stringResult);

            // PART 5: Call the PerformOperation method with an invalid string parameter and display the result
            Console.WriteLine("\nCalling PerformOperation with an invalid string ('abc'):");
            int invalidStringResult = mathOps.PerformOperation("abc");
            Console.WriteLine("Result of trying to convert 'abc' to an integer is: " + invalidStringResult);

            // Pause the console to keep it open and view the results before it closes
            Console.ReadLine();
        }
    }
}