
class Program
{
    static void Main()
    {
        try
        {
          
            decimal price = decimal.Parse(Console.ReadLine());

            if (price <= 0)
            {
                throw new InvalidPriceException();
            }

            int quantity = int.Parse(Console.ReadLine());

            if (quantity <= 0)
            {
                throw new InvalidQuantityException();
            }
            decimal totalCost = price * quantity;
            Console.WriteLine($"Total cost is {Math.Round(totalCost, 1)}");
        }
        catch (InvalidPriceException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (InvalidQuantityException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid number.");
        }
        catch (Exception)
        {
            Console.WriteLine("Error: Please enter a valid number.");
        }
    }
}