using System;

class Program
{
    static void Main(string[] args)
    {
        // Display the welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt the user for package weight
        Console.WriteLine("Please enter the package weight:");
        int packageWeight = Convert.ToInt32(Console.ReadLine());

        // Check if the package weight is too heavy
        if (packageWeight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
        }
        else
        {
            // Prompt the user for package width
            Console.WriteLine("Please enter the package width:");
            int packageWidth = Convert.ToInt32(Console.ReadLine());

            // Prompt the user for package height
            Console.WriteLine("Please enter the package height:");
            int packageHeight = Convert.ToInt32(Console.ReadLine());

            // Prompt the user for package length
            Console.WriteLine("Please enter the package length:");
            int packageLength = Convert.ToInt32(Console.ReadLine());

            // Check if the total dimensions are too big
            int dimensionsTotal = packageWidth + packageHeight + packageLength;
            if (dimensionsTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            else
            {
                // Calculate the shipping quote
                int quote = (packageWidth * packageHeight * packageLength) * packageWeight / 100;

                // Display the shipping quote
                Console.WriteLine("Your estimated total for shipping this package is: $" + quote + ".00");
                Console.WriteLine("Thank you!");
            }
        }

        // Pause the console so the program doesn't exit immediately
        Console.ReadLine();
    }
}
