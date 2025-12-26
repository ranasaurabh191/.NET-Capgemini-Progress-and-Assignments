class Calculator
{
    int number1;
    int number2;
    int result;
    public int Number1{ get;set;}
    public int Number2{ get;set;}
    public int Result{ get;set;}

    public Calculator()
    {
        number1 = 0;
        number2 = 0;
        result = 0;
    }
    public Calculator(int number1, int number2)
    {
        this.number1 = number1;
        this.number2 = number2;
        
        
    }
    public void Add(int n1, int n2, out int result, out int num3, out int num4)
    {
        number1 = n1;
        number2 = n2;
        result = number1 + number2;
        num3 = number1;
        num4 = number2;
    }
}