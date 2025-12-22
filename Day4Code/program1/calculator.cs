class Calculator
{
    private int number1;
    private int number2;

    public int Number1 { get; set; }
    public int Number2 { get; set; }

    public Calculator(int Number1 = 0, int Number2 = 0)
    {
        this.Number1 = Number1;
        this.Number2 = Number2;
    }
}