// Case Study 3: Employee Payroll – Call by Value
// Scenario
// In a payroll system, salary values are passed to a method for calculation, but the original values must remain unchanged after method execution.
// Requirement
// •	Pass two salary components to a method
// •	Swap values internally
// •	Ensure original values remain unchanged
// C# Concepts Used
// •	Call by Value
// •	Local scope of variables
// Mapping to Code
// public void Swap(int num1, int num2)
// Observation
// Even after swapping inside the method, original values do not change.
// Learning Outcome
// ✔ Understand call by value
// ✔ Data safety in applications

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