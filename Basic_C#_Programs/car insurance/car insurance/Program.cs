using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask for the applicant's age
        Console.WriteLine("What is your age?");
        int age = Convert.ToInt32(Console.ReadLine()); 

        // Ask if the applicant has had a DUI
        Console.WriteLine("Have you ever had a DUI? (true/false)");
        bool hasDUI = Convert.ToBoolean(Console.ReadLine()); 

        // Ask how many speeding tickets the applicant has
        Console.WriteLine("How many speeding tickets do you have?");
        int speedingTickets = Convert.ToInt32(Console.ReadLine()); 

        // Determine if the applicant qualifies for car insurance
        // The rules: over 15 years old, no DUIs, no more than 3 speeding tickets
        bool isQualified = (age > 15 && !hasDUI && speedingTickets <= 3);

        // Print whether the applicant is qualified or not
        Console.WriteLine("Qualified?");
        Console.WriteLine(isQualified); 

        // Pause the console so the program doesn't exit immediately
        Console.ReadLine();
    }
}