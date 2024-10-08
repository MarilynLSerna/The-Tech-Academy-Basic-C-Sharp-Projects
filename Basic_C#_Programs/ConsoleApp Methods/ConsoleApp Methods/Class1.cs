using System;

namespace CallingMethodsApp
{
    // Create a MathOperations class to contain three methods for math operations.
    public class MathOperations
    {
        // Method 1: Adds 10 to the input number
        public int AddTen(int number)
        {
            return number + 10;
        }

        // Method 2: Multiplies the input number by 5
        public int MultiplyByFive(int number)
        {
            return number * 5;
        }

        // Method 3: Subtracts 7 from the input number
        public int SubtractSeven(int number)
        {
            return number - 7;
        }
    }
}