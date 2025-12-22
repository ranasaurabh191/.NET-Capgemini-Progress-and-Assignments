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
class Calculator
{
    int number1;
    int number2;
    public Calculator()
    {
        number1 = 200;
        number2 = 20;
    }


    //addition
    public int Add(int n1, int n2)
    {
        return n1 + n2;
    }
    //subtraction
    public int Subtract()
    {
        return number1 - number2;
    }
    //multiplication
    public void Multiply(int n1, int n2)
    {
        Console.WriteLine("Multiplication: " + (n1 * n2));
    }
    //division
    public void Divide()
    {
        Console.WriteLine("Division: " + (number1 / number2));
    }

}