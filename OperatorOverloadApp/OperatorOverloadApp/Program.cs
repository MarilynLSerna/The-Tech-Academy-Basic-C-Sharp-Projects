using System;

namespace OperatorsSubmissionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // PART 1: Instantiate and initialize two Employee objects.
            Employee emp1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
            Employee emp2 = new Employee { Id = 1, FirstName = "Jane", LastName = "Smith" };

            // PART 2: Compare the two Employee objects using the overloaded == operator.
            if (emp1 == emp2)
            {
                Console.WriteLine("The two employees are considered equal (by their Id).");
            }
            else
            {
                Console.WriteLine("The two employees are not equal (by their Id).");
            }

            // PART 3: Compare the two Employee objects using the overloaded != operator.
            if (emp1 != emp2)
            {
                Console.WriteLine("The two employees are considered different (by their Id).");
            }
            else
            {
                Console.WriteLine("The two employees are considered the same (by their Id).");
            }

            Console.ReadLine();
        }
    }
}
