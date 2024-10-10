using System;

namespace MethodClassApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // PART 1: Instantiate the MathOperations class to access its methods.
            MathOperations mathOps = new MathOperations();

            // PART 2: Call the ProcessNumbers method, passing in two integers as positional arguments.
            Console.WriteLine("Calling ProcessNumbers with positional arguments (10, 20):");
            mathOps.ProcessNumbers(10, 20); // Passes 10 and 20 as positional arguments

            // PART 3: Call the ProcessNumbers method, specifying the parameters by name.
            Console.WriteLine("\nCalling ProcessNumbers with named arguments (num1: 5, num2: 15):");
            mathOps.ProcessNumbers(num1: 5, num2: 15); // Passes 5 and 15 using named arguments

            // Pause the console to keep it open and view the results before it closes.
            Console.ReadLine();
        }
    }
}
