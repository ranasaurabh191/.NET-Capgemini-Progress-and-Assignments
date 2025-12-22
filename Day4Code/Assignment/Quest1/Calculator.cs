
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