class Program
{
    static void Main()
    {
        PayRoll payroll = new PayRoll();

        int salaryComponent1 = 5000;
        int salaryComponent2 = 7000;

        Console.WriteLine("Before Swap:");
        Console.WriteLine("Salary Component 1: " + salaryComponent1);
        Console.WriteLine("Salary Component 2: " + salaryComponent2);

        payroll.Swap(salaryComponent1, salaryComponent2);

        Console.WriteLine("\nAfter Swap (Outside Method):");
        Console.WriteLine("Salary Component 1: " + salaryComponent1);
        Console.WriteLine("Salary Component 2: " + salaryComponent2);
    }
}