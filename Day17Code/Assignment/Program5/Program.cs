public class Program
{
    public Chocolate CalculateDiscountedPrice(Chocolate ch)
    {
        ch.TotalPrice = ch.Quantity * ch.PricePerUnit;

        double discountPercentage = 0;

        if (ch.Flavour == "Dark")
            discountPercentage = 18;
        else if (ch.Flavour == "Milk")
            discountPercentage = 12;
        else if (ch.Flavour == "White")
            discountPercentage = 6;

        ch.DiscountedPrice = ch.TotalPrice - (ch.TotalPrice * discountPercentage / 100);

        return ch;
    }

    public static void Main()
    {
        Program program = new Program();
        Chocolate choco = new Chocolate();

        Console.WriteLine("Enter the flavour");
        choco.Flavour = Console.ReadLine()??"";

        Console.WriteLine("Enter the quantity");
        choco.Quantity = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the price per unit");
        choco.PricePerUnit = Convert.ToInt32(Console.ReadLine());

        if (!choco.ValidateChocolateFlavour())
        {
            Console.WriteLine("Invalid flavour");
        }
        else
        {
            choco = program.CalculateDiscountedPrice(choco);

            Console.WriteLine("Flavour : " + choco.Flavour);
            Console.WriteLine("Quantity : " + choco.Quantity);
            Console.WriteLine("Price Per Unit : " + choco.PricePerUnit);
            Console.WriteLine("Total Price : " + choco.TotalPrice);
            Console.WriteLine("Discounted Price : " + choco.DiscountedPrice);
        }
    }
}
