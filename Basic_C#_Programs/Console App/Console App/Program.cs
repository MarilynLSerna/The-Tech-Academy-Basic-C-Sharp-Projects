using System;

class Program
{
    static void Main(string[] args)
    {
        // Boolean comparison using a while statement
        Console.WriteLine("Boolean Comparison Using a While Statement");

        
        int counter = 0;

        // Continue executing as long as the condition (counter < 5) is true
        while (counter < 5)
        {
            Console.WriteLine("Counter value in while loop: " + counter);
            counter++; 
        }

        // Boolean comparison using a do-while statement
        Console.WriteLine("\nBoolean Comparison Using a Do-While Statement");

        // Reset the counter for the do-while example
        counter = 5;

        // Execute the block at least once, then continue as long as the condition (counter < 5) is true
        do
        {
            Console.WriteLine("Counter value in do-while loop: " + counter);
            counter--; 
        }
        while (counter > 0); 

        // Pause the console to see the results before it closes
        Console.ReadLine();
    }
}
