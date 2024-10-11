using System;

namespace MethodsAndObjectsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // PART 1: Instantiate and initialize an Employee object with a first name and last name.
            Employee employee = new Employee
            {
                FirstName = "Tony",  
                LastName = "Lopez"   
            };

            // PART 2: Call the SayName() method on the Employee object, which is inherited from the Person class.
            employee.SayName();

            
            Console.ReadLine();
        }
    }
}