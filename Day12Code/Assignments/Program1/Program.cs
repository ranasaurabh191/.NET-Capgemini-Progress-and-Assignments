class InvalidInputException : Exception
{
    public InvalidInputException(string message) : base(message){}
}
class InvalidTypeException : Exception
{
    public InvalidTypeException(string message) : base(message){}
}

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter temperature value: ");
            string input = Console.ReadLine()??"";

            if (!double.TryParse(input, out double value))
            {
                throw new InvalidInputException("Error: Invalid input provided.\nException Message: Input string was not in a correct format.");
            }

            Console.Write("Enter conversion type (C/F): ");
            string conversion = (Console.ReadLine() ?? "").Trim().ToLower();

            if (string.IsNullOrWhiteSpace(conversion))
            {
                throw new InvalidTypeException("Conversion type cannot be empty.");
            }

            if (conversion != "c" && conversion != "f")
            {
                throw new InvalidTypeException("Invalid conversion type. Please enter 'F' or 'C'.");
            }

            if (conversion == "f")
            {
                double result = (value - 32) * 5 / 9;
                Console.WriteLine("Temperature in Celsius: {0:F}",result);
            }
            else
            {
                double result = (value * 9 / 5) + 32;
                Console.WriteLine("Temperature in Fahrenheit: {0:F}",result);
            }
        }
        catch (InvalidInputException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (InvalidTypeException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
