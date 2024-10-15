using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaSubmissionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // PART 1: Create a list of at least 10 employees.
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 1, FirstName = "Joe", LastName = "Smith" },
                new Employee { Id = 2, FirstName = "Jane", LastName = "Doe" },
                new Employee { Id = 3, FirstName = "Joe", LastName = "Johnson" },
                new Employee { Id = 4, FirstName = "Emily", LastName = "Davis" },
                new Employee { Id = 5, FirstName = "Michael", LastName = "Clark" },
                new Employee { Id = 6, FirstName = "Sarah", LastName = "Brown" },
                new Employee { Id = 7, FirstName = "Tom", LastName = "Jones" },
                new Employee { Id = 8, FirstName = "Anna", LastName = "Wilson" },
                new Employee { Id = 9, FirstName = "David", LastName = "Taylor" },
                new Employee { Id = 10, FirstName = "Joe", LastName = "Williams" }
            };

            // PART 2: Use a foreach loop to create a new list of employees with the first name "Joe".
            List<Employee> joesList1 = new List<Employee>();  // Create a new list to store employees named Joe.
            foreach (Employee emp in employees)
            {
                if (emp.FirstName == "Joe")
                {
                    joesList1.Add(emp);  // Add employees with first name "Joe" to the new list.
                }
            }

            // Print the list of employees named Joe.
            Console.WriteLine("Employees named Joe (using foreach loop):");
            foreach (Employee joe in joesList1)
            {
                Console.WriteLine($"{joe.FirstName} {joe.LastName}, Id: {joe.Id}");
            }

            // PART 3: Perform the same action using a lambda expression.
            List<Employee> joesList2 = employees.Where(emp => emp.FirstName == "Joe").ToList();  // Use a lambda expression to filter.

            // Print the list of employees named Joe using lambda.
            Console.WriteLine("\nEmployees named Joe (using lambda expression):");
            foreach (Employee joe in joesList2)
            {
                Console.WriteLine($"{joe.FirstName} {joe.LastName}, Id: {joe.Id}");
            }

            // PART 4: Use a lambda expression to make a list of employees with Id > 5.
            List<Employee> employeesWithIdGreaterThanFive = employees.Where(emp => emp.Id > 5).ToList();  // Filter employees with Id > 5.

            // Print the list of employees with Id greater than 5.
            Console.WriteLine("\nEmployees with Id greater than 5:");
            foreach (Employee emp in employeesWithIdGreaterThanFive)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}, Id: {emp.Id}");
            }

            Console.ReadLine();
        }
    }
}