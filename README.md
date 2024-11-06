# C# Projects

These are some small projects I created using C# and .NET Framework.

---

## Projects:

- [CarInsurance](#car-insurance)
- [StudentDatabase](#student-database)

---

## Car Insurance

This project is an MVC web application that mimics a car insurance website. It takes user input on policy information and calculates a quote based on business logic. There is also an admin page that allows staff to view all of the quotes that have been issued.

### Features:
- User input collection for policy information (e.g., car model, DUI status, etc.)
- Real-time quote calculation based on various criteria
- Admin view for listing all insurance quotes

**Technologies Used:**
- ASP.NET Core MVC
- Entity Framework Core
- SQL Server (LocalDB)

---

## Student Database

The "Student Database" project is a console application that uses Entity Framework Code-First to create a database for managing student information. The program adds a student record to the database upon execution.

### Features:
- Defines a basic `Student` model with properties like `FirstName`, `LastName`, and `EnrollmentDate`
- Uses Entity Framework Code-First approach to create and manage the database schema
- Adds a new student to the database on each run and displays a success message

**Technologies Used:**
- C# Console Application
- Entity Framework Core
- SQL Server (LocalDB)
