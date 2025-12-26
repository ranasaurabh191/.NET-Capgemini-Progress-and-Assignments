using System.Globalization;

class Program
{
    public static void Main()
    {
        //object initialiser
        // Employee emp1 = new Employee
        // {
        //     EmployeeId = 101,
        //     Name = "Rajesh",
        //     Salary = 23423.23f
        // };
        // Console.WriteLine("Employee id : "+emp1.EmployeeId);    
        // Console.WriteLine("Employee name : "+emp1.Name);    
        // Console.WriteLine("Employee salary : "+emp1.Salary);    

        // Console.WriteLine(emp1);   
        // int[] arr = [12,232]; 
        // emp1.Add(arr);
        // Calculator cal = new Calculator();
        // cal.Add();
        // cal.Add(2,4);
        // cal.Add(1231.23);
        // cal.Add(23.4f,32.4f);
        // cal.Add("hello","world");
        // double distance = 50.0;
        // double hour = 5.0;
        // double fuel = 10.0;
        // Vehicle v1 = new Car(distance,hour,fuel);
        // v1.Average();
        // v1.Speed();

        Furniture fur = new Chair();
        // Bookshelve bk = new Bookshelve();
        // bk.Accept();
        // bk.Display();

        // Chair ch = new Chair();
        fur.Accept();
        fur.Display();

    }
}