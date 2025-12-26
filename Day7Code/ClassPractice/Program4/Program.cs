namespace CalculatorApp
{
    public delegate int CalculatorDelegate(int num1,int num2);

    class Program
    {
        static void Main()
        {
            Calculator cal = new Calculator();
            CalculatorDelegate calAdd = new CalculatorDelegate(cal.Add);
            CalculatorDelegate calSubtract = new CalculatorDelegate(cal.Subtract);
            CalculatorDelegate calMulti = new CalculatorDelegate(cal.Multiply);
            CalculatorDelegate calDiv = new CalculatorDelegate(cal.Divide);
            CalculatorDelegate calMulticast;

            Console.WriteLine("sum : "+calAdd(2,4));
            Console.WriteLine("Sub : "+calSubtract(2,4));
            Console.WriteLine("Mult : "+calMulti(2,4));
            Console.WriteLine("Div : "+calDiv(20,4));
        
            calMulticast = calAdd;
            calMulticast += calSubtract;
            calMulticast -= calMulti;
            calMulticast += calDiv;

            Console.WriteLine("Called multicast: "+calMulticast(30,3));

        }
    }
    
}