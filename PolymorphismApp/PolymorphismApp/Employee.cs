using System;

namespace PolymorphismApp
{
    // The Employee class inherits from the Person class and implements the IQuittable interface.
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }

        // Implement the SayName() method from the Person class.
        public override void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }

        // Implement the Quit() method from the IQuittable interface.
        public void Quit()
        {
            Console.WriteLine($"{FirstName} {LastName} has quit the job.");
        }
    }
}
