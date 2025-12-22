// Case Study 1: Banking System – Basic Arithmetic Operations
// Scenario
// A banking application needs a utility class to perform basic arithmetic operations such as addition, subtraction, multiplication, and division for internal calculations like balance updates, interest calculation, and transaction summaries.
// Requirement
// •	Create a Calculator class
// •	Support:
// o	Addition of two numbers
// o	Subtraction without user input
// o	Multiplication with input parameters
// o	Division using predefined values
// •	Display results where required
// C# Concepts Used
// •	Class and Object
// •	Default Constructor
// •	Parameterized Methods
// •	Return types and void methods
// Mapping to Code
// Add(int number1, int number2)
// Subtract()
// Multiply(int number1, int number2)
// Divide()
// Learning Outcome
// ✔ Understand method overloading
// ✔ Difference between methods with/without parameters
// ✔ Difference between methods with/without return type
// ________________________________________

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        Console.WriteLine("Addition: " + calc.Add(15, 5));
        Console.WriteLine("Subtraction: " + calc.Subtract());
        calc.Multiply(4, 5);
        calc.Divide();
    }
}