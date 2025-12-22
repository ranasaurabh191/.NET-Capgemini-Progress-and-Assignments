class Calculator
{
    private int number1;
    private int number2;

    public Calculator()
    {
        number1 = 140;
        number2 = 120;
    }

    public Calculator(int number1, int number2)
    {
        this.number1 = number1;
        this.number2 = number2;
    }
    
    public void Add()
    {
        int result = number1 + number2;
        Console.WriteLine("Addition: " + result);
    }   
}