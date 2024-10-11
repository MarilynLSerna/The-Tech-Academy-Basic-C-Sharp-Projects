using System;

namespace AbstractClassApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // PART 1: Instantiate and initialize an Employee object with firstName and lastName.
            Employee employee = new Employee
            {
                FirstName = "John",  // Set the FirstName property of the Employee object.
                LastName = "Smith"   // Set the LastName property of the Employee object.
            };

            // PART 2: Call the SayName() method on the Employee object.
            employee.SayName();

            // Pause the console to keep it open and view the results before it closes.
            Console.ReadLine();
        }
    }
}
