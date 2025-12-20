using System;

class Program
{
    public static void Main()
    {
        Students stu = new Students(); //creating object of Students class
        Console.WriteLine("Enter Student Details:");
        stu.AcceptDetails(); //calling method to accept student details
        Console.WriteLine();
        Console.WriteLine("\nStudent Details:");
        stu.DisplayDetails();
        stu.calculateTotalAndAverage();
    }
}