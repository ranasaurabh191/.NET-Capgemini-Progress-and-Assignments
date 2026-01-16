public class Program
{
    public static void Main()
    {
        Console.WriteLine("1.Desktop");
        Console.WriteLine("2.Laptop");
        Console.WriteLine("Choose the option");
        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            Desktop desk = new Desktop();

            Console.WriteLine("Enter the processor");
            desk.Processor = Console.ReadLine();

            Console.WriteLine("Enter the ram size");
            desk.RamSize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the hard disk size");
            desk.HardDiskSize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the graphic card size");
            desk.GraphicCard = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the monitor size");
            desk.MonitorSize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the power supply volt");
            desk.PowerSupplyVolt = Convert.ToInt32(Console.ReadLine());

            double result = desk.DesktopPriceCalculation();
            Console.WriteLine("Desktop price is " + result);
        }
        else if (choice == 2)
        {
            Laptop lap = new Laptop();

            Console.WriteLine("Enter the processor");
            lap.Processor = Console.ReadLine();

            Console.WriteLine("Enter the ram size");
            lap.RamSize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the hard disk size");
            lap.HardDiskSize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the graphic card size");
            lap.GraphicCard = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the display size");
            lap.DisplaySize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the battery volt");
            lap.BatteryVolt = Convert.ToInt32(Console.ReadLine());

            double result = lap.LaptopPriceCalculation();
            Console.WriteLine("Laptop price is " + result);
        }
    }
}