class Program
{
    static void Main()
    {
        bool exit = false;

        while (exit==false)
        {
            Console.WriteLine("================== QuickMart Traders ==================");
            Console.WriteLine("1. Create New Transaction (Enter Purchase & Selling Details)");
            Console.WriteLine("2. View Last Transaction");
            Console.WriteLine("3. Calculate Profit/Loss (Recompute & Print)");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your option: ");

            string choice = Console.ReadLine()??"";
            switch (choice)
            {
                case "1":
                    SaleTransaction.Create();
                    break;
                case "2":
                    SaleTransaction.View();
                    break;
                case "3":
                    SaleTransaction.Recalculate();
                    break;
                case "4":
                    Console.WriteLine("Thank you. Application closed normally.");
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please select a valid menu choice.");
                    break;
          
            }
        }
    }
}
