using System;

class Program
{
    static void Main()
    {
        // Print current date and time
        Console.WriteLine("Current date and time: " + DateTime.Now);

        // Ask user for a number
        Console.WriteLine("Enter a number of hours: ");
        int hours = Convert.ToInt32(Console.ReadLine());

        // Add the user-entered number to the current time and display the future time
        DateTime futureTime = DateTime.Now.AddHours(hours);
        Console.WriteLine("In {0} hours, the time will be: {1}", hours, futureTime);

        Console.ReadLine();
    }
}