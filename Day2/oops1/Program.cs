using System;
class Program
{
    public static void Main()
    {
        Employee emp = new Employee(); //creating object of Employee class
        // emp.AcceptDetails(); //calling AcceptDetails method/ binding the employee object with AcceptDetails method
        // Console.WriteLine(); // to give a blank line
        // emp.DisplayDetails(); // calling DisplayDetails method/ binding the employee object with DisplayDetails method
        // Console.ReadKey(); // to hold the console screen
        
        emp.EmpId = 101; // accessing empId field of Employee class using employee object
        Console.WriteLine($"Employee Id: {emp.EmpId}"); // accessing empId field makking that public first 
        
        emp.EmpName = "John Doe"; // accessing empName field of Employee class using employee object
        Console.WriteLine($"Employee Name: {emp.EmpName}"); // accessing empName field
        
        emp.Department = "IT"; // accessing department field of Employee class using employee object
        Console.WriteLine($"Department: {emp.Department}"); // accessing department field
        
        emp.Salary = 75000.50f; // accessing salary field of Employee class using employee object
        Console.WriteLine($"Salary: {emp.Salary}"); // accessing salary field
        
        emp.Status = true; // accessing status field of Employee class using employee object
        Console.WriteLine($"Status on Project: {emp.Status}"); // accessing status field

    }
}