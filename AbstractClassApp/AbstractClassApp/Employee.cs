using System;

namespace AbstractClassApp
{
    // Create an Employee class that inherits from the Person abstract class.
    public class Employee : Person
    {
        // Implement the abstract method SayName() defined in the Person class.
        public override void SayName()
        {
            // Output the full name to the console.
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}
