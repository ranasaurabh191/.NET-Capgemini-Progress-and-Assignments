// Case Study 2: Billing Software – Constructor Usage
// Scenario
// A retail billing system initializes calculation objects differently based on whether default values or customer-specific values are available.
// Requirement
// •	Initialize calculator with default values
// •	Initialize calculator with given numbers for immediate calculation
// C# Concepts Used
// •	Default Constructor
// •	Parameterized Constructor
// •	this keyword
// Mapping to Code
// public Calculator()
// public Calculator(int Number1, int Number2)
// Learning Outcome
// ✔ Understand object initialization
// ✔ Use of constructors in real applications

class Program
{
    public static void Main()
    {
        //default constructor
        Calculator calcDefault = new Calculator();
        calcDefault.Add();
        //parameterized constructor
        Calculator calcParam = new Calculator(50, 70);
        calcParam.Add();
       

    }
}