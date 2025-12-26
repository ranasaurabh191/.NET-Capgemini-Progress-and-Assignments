using System;
class Employee // public by default
{
    private int empId=0; // private by default
    private string empName = string .Empty; // private by default
    private string department = string.Empty; // private by default
    private float salary = 0.0f; // private by default
    private bool status = true; // private by default
    
    public int EmpId // property for empId field
    {
        get { return empId; }
        set { empId = value; }
    }
    public string EmpName // property for empName field
    {
        get { return empName; }
        set { empName = value; }
    }
    public string Department // property for department field
    {
        get { return department; }
        set { department = value; }
    }
    public float Salary // property for salary field
    {
        get { return salary; }
        set { salary = value; }
    }
    public bool Status // property for status field
    {
        get { return status; }
        set { status = value; }
    }

    public void AcceptDetails() 
    {
        Console.WriteLine("**** Enter Employee Details ****");

        Console.Write("Enter Employee Id: ");
        empId = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Employee Name: ");
        empName = Console.ReadLine() ?? "";

        Console.Write("Enter Department: ");
        department = Console.ReadLine() ?? "";

        Console.Write("Enter Salary: ");
        salary = Convert.ToSingle(Console.ReadLine());

        Console.Write("Enter Status on Project(true/false): ");
        status = Convert.ToBoolean(Console.ReadLine());
    
    }
    public void DisplayDetails()
    {
        Console.WriteLine("**** Employee Details Are ****");
        Console.WriteLine($"Employee Id: {empId}");
        Console.WriteLine($"Employee Name: {empName}");
        Console.WriteLine($"Department: {department}");
        Console.WriteLine($"Salary: {salary}");
        Console.WriteLine($"Status on Project: {status}");
    }

}