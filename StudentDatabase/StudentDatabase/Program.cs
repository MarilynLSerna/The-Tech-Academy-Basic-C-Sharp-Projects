using StudentDatabase;
using System;

class Program
{
    static void Main()
    {
        using (var context = new StudentContext())
        {
            // Create a new student
            var student = new Student
            {
                FirstName = "Obanai",
                LastName = "Iguro",
                EnrollmentDate = DateTime.Now
            };

            // Add the student to the context
            context.Students.Add(student);

            // Save the changes to the database
            context.SaveChanges();

            Console.WriteLine("Student added successfully!");
        }
    }
}