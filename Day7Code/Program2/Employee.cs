class Employee
{
    protected int Eid,Eage;
    protected string Ename= "", Eaddress="";
    protected double Salary;
    public virtual void GetEmployeeData()
    {
        Console.WriteLine("\nEnter Employee Details: ");
        Console.Write("Enter the id: ");
        Eid = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the name: ");
        Ename = Console.ReadLine()??"";
        Console.Write("Enter the address: ");
        Eaddress = Console.ReadLine()??"";
        Console.Write("Enter the age: ");
        Eage = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the salary: ");
        Salary = Convert.ToDouble(Console.ReadLine());

    }
    public virtual void DisplayEmployeeData()
    {
        Console.WriteLine("\nEmployee Details are: ");
        Console.WriteLine("Employee id is : "+Eid);
        Console.WriteLine("Employee name is : "+Ename);
        Console.WriteLine("Employee address is : "+Eaddress);
        Console.WriteLine("Employee age is : "+Eage);
        Console.WriteLine("Employee salary is : "+Salary);
    }
    public virtual void CalculateSalary()
    {
        Console.WriteLine("\nEmployee salary is : "+Salary);
    }
}