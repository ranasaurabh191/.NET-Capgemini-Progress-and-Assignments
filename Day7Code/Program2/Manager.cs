class Manager : Employee
{
    double Bonus,CA;
    public override void GetEmployeeData()
    {
        Console.WriteLine("\nEnter manager Details:");
        Console.Write("Enter the id: ");
        Eid = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the name: ");
        Ename = Console.ReadLine()??"";
        Console.Write("Enter the bonus: ");
        Bonus = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the CA: ");
        CA = Convert.ToDouble(Console.ReadLine());
    }
    public override void DisplayEmployeeData()
    {
        Console.WriteLine("\nManager Details are: ");
        Console.WriteLine("Manager id is : "+Eid);
        Console.WriteLine("Manager name is : "+Ename);
        Console.WriteLine("Manager bonus is : "+Bonus);
        Console.WriteLine("Manager ca is : "+CA);
    }
    public override void CalculateSalary()
    {
        Console.WriteLine("\nManager salary is : "+Salary);
    }
}
