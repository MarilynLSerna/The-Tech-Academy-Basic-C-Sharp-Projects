using System;

class Program
{
    // Declare a constant variable
    const string welcomeMessage = "Welcome to the Constructor Assignment!";

    static void Main(string[] args)
    {
        var number = 10;

        // Instance of the Person class using the chained constructor
        Person person = new Person("John");

        Console.WriteLine(welcomeMessage);
        Console.WriteLine("Name: " + person.Name);
        Console.WriteLine("Age: " + person.Age);
        Console.ReadLine();
    }
}

// Person class demonstrating constructor chaining
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Constructor with one parameter, chaining to the second constructor
    public Person(string name) : this(name, 25) // Chain to the second constructor
    {
    }

    // Second constructor with two parameters
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}
