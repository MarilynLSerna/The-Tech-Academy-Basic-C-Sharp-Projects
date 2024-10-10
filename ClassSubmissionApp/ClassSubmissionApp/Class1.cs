using System;

namespace ClassSubmissionApp
{
    // Create a static class named MathOperations.
    public static class MathOperations
    {
        // Create a void method that takes an integer and outputs the result of dividing it by 2.
        public static void DivideByTwo(int number, out int result)
        {
            // Divide the number by 2 and set the result as an output parameter.
            result = number / 2;
        }

        // Create an overloaded method that accepts a double and outputs the result of dividing it by 2.
        public static void DivideByTwo(double number, out double result)
        {
            // Divide the number by 2 and set the result as an output parameter.
            result = number / 2;
        }

        // Create another method that demonstrates the use of an output parameter.
        public static void SquareNumber(int input, out int squaredResult)
        {
            // Calculate the square of the input and set it as the output parameter.
            squaredResult = input * input;
        }
    }
}