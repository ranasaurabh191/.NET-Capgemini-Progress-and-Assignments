
public class Program
{
    public static void Main()
    {
        try
        {
            int numberOfTickets = int.Parse(Console.ReadLine());

            if (numberOfTickets <= 0)
                throw new ArgumentException("Error: Number of tickets must be greater than 0.");

            decimal pricePerTicket = decimal.Parse(Console.ReadLine());

            if (pricePerTicket <= 0)
                throw new ArgumentException("Error: Price per ticket must be greater than 0.");

            decimal totalCost = numberOfTickets * pricePerTicket;

            Console.WriteLine($"Total ticket cost: {totalCost}");
        }
        catch (ArgumentException ex)
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
