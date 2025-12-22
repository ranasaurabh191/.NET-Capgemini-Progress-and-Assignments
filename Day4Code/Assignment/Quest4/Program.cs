// Case Study 4: HR System – Call by Reference
// Scenario
// An HR application allows administrators to permanently swap employee IDs or role priorities.
// Requirement
// •	Swap two values
// •	Changes must reflect outside the method
// C# Concepts Used
// •	ref keyword
// •	Call by Reference
// Mapping to Code
// public void Swap1(ref int num3, ref int num4)
// Learning Outcome
// ✔ Difference between ref and normal parameters
// ✔ Real-time data modification

class Program
{
    static void Main()
    {
        HR hr = new HR();

        int employeeID1 = 101;
        int employeeID2 = 202;

        Console.WriteLine("Before Swap:");
        Console.WriteLine("Employee ID 1: " + employeeID1);
        Console.WriteLine("Employee ID 2: " + employeeID2);

        hr.Swap1(ref employeeID1, ref employeeID2);

        Console.WriteLine("\nAfter Swap (Outside Method):");
        Console.WriteLine("Employee ID 1: " + employeeID1);
        Console.WriteLine("Employee ID 2: " + employeeID2);
    }
}