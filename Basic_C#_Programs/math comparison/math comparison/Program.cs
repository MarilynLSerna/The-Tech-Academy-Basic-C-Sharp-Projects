using System;

class Program
{
    static void Main(string[] args)
    {
        // Print the title of the program
        Console.WriteLine("Anonymous Income Comparison Program");

        // Gather details for Person 1
        Console.WriteLine("Person 1");
        Console.WriteLine("Hourly Rate?");
        double hourlyRate1 = Convert.ToDouble(Console.ReadLine()); // Get hourly rate input from user
        Console.WriteLine("Hours worked per week?");
        double hoursWorked1 = Convert.ToDouble(Console.ReadLine()); // Get hours worked input from user

        // Gather details for Person 2
        Console.WriteLine("Person 2");
        Console.WriteLine("Hourly Rate?");
        double hourlyRate2 = Convert.ToDouble(Console.ReadLine()); // Get hourly rate input from user
        Console.WriteLine("Hours worked per week?");
        double hoursWorked2 = Convert.ToDouble(Console.ReadLine()); // Get hours worked input from user

        // Calculate annual salary for Person 1
        double annualSalary1 = hourlyRate1 * hoursWorked1 * 52; // 52 weeks in a year
        Console.WriteLine("Annual salary of Person 1:");
        Console.WriteLine(annualSalary1);

        // Calculate annual salary for Person 2
        double annualSalary2 = hourlyRate2 * hoursWorked2 * 52; // 52 weeks in a year
        Console.WriteLine("Annual salary of Person 2:");
        Console.WriteLine(annualSalary2);

        // Compare salaries
        bool doesPerson1MakeMore = annualSalary1 > annualSalary2;
        Console.WriteLine("Does Person 1 make more money than Person 2?");
        Console.WriteLine(doesPerson1MakeMore);

        // Pause the console to see the results before it closes
        Console.ReadLine();
    }
}