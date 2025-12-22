// Case Study 6: Utility Service – Auto-Implemented Properties
// Scenario
// A shared utility service stores input values and results for reuse across multiple calculations.
// Requirement
// •	Store numbers and results
// •	Provide controlled access
// C# Concepts Used
// •	Auto-implemented properties
// •	Encapsulation
// Mapping to Code
// public int Number1 { get; set; }
// public int Number2 { get; set; }
// public int Result { get; set; }
// Learning Outcome
// ✔ Clean property implementation
// ✔ Encapsulation best practices
// ________________________________________
class Program
{
    static void Main()
    {
        UtilityService utilService = new UtilityService();

        utilService.Number1 = 50;
        utilService.Number2 = 70;

        utilService.Result = utilService.Number1 + utilService.Number2;

        Console.WriteLine("Number 1: " + utilService.Number1);
        Console.WriteLine("Number 2: " + utilService.Number2);
        Console.WriteLine("Result (Sum): " + utilService.Result);
    }
}   