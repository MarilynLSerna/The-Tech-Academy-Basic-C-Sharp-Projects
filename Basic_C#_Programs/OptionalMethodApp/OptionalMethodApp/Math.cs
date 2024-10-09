using System;

namespace OptionalParameterApp
{
    // Create a MathOperations class with a method that accepts two integers, one of which is optional.
    public class MathOperations
    {
        // Method that takes two integers as parameters, with the second one being optional and having a default value of 0.
        public int AddNumbers(int num1, int num2 = 0)
        {
            // Perform an addition operation and return the result.
            return num1 + num2;
        }
    }
}