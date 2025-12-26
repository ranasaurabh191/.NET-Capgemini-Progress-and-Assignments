using System;

class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();
        int number1 = 10;
        int number2 = 20;
        int sum = calculator.Add(number1, number2);
        Console.WriteLine($"The sum of {number1} and {number2} is: {sum}");

        Calculator calculator2 = new Calculator(20,40);
        
    }
}