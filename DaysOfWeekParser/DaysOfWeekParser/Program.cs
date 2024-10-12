using System;

namespace ParsingEnumsApp
{
    // Define an enum for the days of the week.
    public enum DaysOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the current day of the week.
            Console.WriteLine("Please enter the current day of the week:");

            // PART 1: Try to parse the user's input into the DaysOfWeek enum.
            try
            {
                string userInput = Console.ReadLine();  // Get user input
                DaysOfWeek currentDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), userInput, true);  // Parse input
                Console.WriteLine($"You have entered: {currentDay}");
            }
            catch (ArgumentException)
            {
                // PART 2: Handle invalid input.
                Console.WriteLine("Please enter an actual day of the week.");
            }

            // Pause the console to keep it open and view the results before it closes.
            Console.ReadLine();
        }
    }
}