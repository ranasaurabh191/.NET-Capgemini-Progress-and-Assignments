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

        //using getter and setter methods to retrieve student details
        Students stu1 = new Students();
        stu1.StudentNum = 101;
        stu1.StudentName = "John Doe";
        Console.WriteLine("\nUsing Getter and Setter Methods:");
        Console.WriteLine("Student Number: " + stu1.StudentNum);
        Console.WriteLine("Student Name: " + stu1.StudentName);  

    }
}