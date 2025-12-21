using System;

class Program
{
    public static void Main()
    {
        Employee emp = new Employee(); //creating object of Employee class
        Console.WriteLine("Enter Employee Details:");
        emp.AcceptDetails(); //calling method to accept employee details
        Console.WriteLine();
        Console.WriteLine("\nEmployee Details:");

        emp.Pf();
        emp.Hra();
        emp.Da();
        emp.DisplayDetails();
        

    }
}