using System;

namespace AbstractClassApp
{
    // Create an abstract class named Person with two properties: firstName and lastName.
    public abstract class Person
    {
        // Properties for first name and last name, both of type string.
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Abstract method SayName() to be implemented by derived classes.
        public abstract void SayName();
    }
}
