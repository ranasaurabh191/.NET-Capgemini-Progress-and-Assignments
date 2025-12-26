class Program
{
    static void Main()
    {
        
        Calculator calc = new Calculator();
        int n1 = 30;
        int n2 = 40;
        int result = 0;
        int num3=0;
        int num4 =0;
        calc.Add(n1, n2,out result,out num3,out num4);
        Console.WriteLine($"Sum: of {num3} and {num4} is " + result);
        
    }
}