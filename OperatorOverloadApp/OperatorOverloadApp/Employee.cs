using System;

namespace OperatorsSubmissionApp
{
    // Create an Employee class with Id, FirstName, and LastName properties.
    public class Employee
    {
        public int Id { get; set; }  // Property for Employee's ID
        public string FirstName { get; set; }  // Property for Employee's first name
        public string LastName { get; set; }  // Property for Employee's last name

        // Overload the == operator to compare Employee objects by their Id property.
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            if (emp1 is null || emp2 is null)
                return false;  // If either employee is null, return false

            return emp1.Id == emp2.Id;  // Compare the Ids of the two Employee objects
        }

        // Overload the != operator as required (comparison operators must be overloaded in pairs).
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);  // Return the opposite result of the == operator
        }

        // Override Equals method to remove compiler warning when overloading == operator
        public override bool Equals(object obj)
        {
            if (obj is Employee employee)
                return this.Id == employee.Id;

            return false;
        }

        // Override GetHashCode method to remove compiler warning when overloading == operator
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
