using System;

namespace PolymorphismApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // PART 1: Instantiate an Employee object with firstName and lastName.
            Employee employee = new Employee
            {
                FirstName = "Jonathan",  // Set the FirstName property of the Employee object.
                LastName = "Smith"   // Set the LastName property of the Employee object.
            };

            // PART 2: Use polymorphism to create an IQuittable object and call the Quit() method.
            IQuittable quittableEmployee = employee;  // Polymorphism: assign the Employee object to an IQuittable type.
            quittableEmployee.Quit();  // Call the Quit() method on the IQuittable object.

            // Pause the console to keep it open and view the results before it closes.
            Console.ReadLine();
        }
    }
}
