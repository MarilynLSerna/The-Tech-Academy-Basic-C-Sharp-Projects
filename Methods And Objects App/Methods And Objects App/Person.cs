using System;

namespace MethodsAndObjectsApp
{
    // Create a class named Person with two string properties: FirstName and LastName.
    public class Person
    {
        public string FirstName { get; set; } 
        public string LastName { get; set; }  

        // Void method that outputs the person's full name in the format "Name: [full name]".
        public void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}
