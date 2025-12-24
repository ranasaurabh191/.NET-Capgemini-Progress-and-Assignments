class Program
{
    public static void Main()
    {
        Console.Write("Enter value:");
        double value = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Enter from unit:");
        string fromUnit = Console.ReadLine() ?? "";

        Console.Write("Enter to unit (press Enter to use default):");
        string toUnit = Console.ReadLine() ?? "";

        UnitConverter converter = new UnitConverter();

        double result = toUnit == "" ? converter.Convert(value, fromUnit) : converter.Convert(value, fromUnit, toUnit);

        Console.WriteLine("Result: "+result);
        
    }
}