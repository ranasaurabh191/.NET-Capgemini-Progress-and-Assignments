class Program
{
    public static void Main()
    {
        
        bool exit = false;
        while (exit==false)
        {
            Console.WriteLine("================== MediSure Clinic Billing ==================");
            Console.WriteLine("1. Create New Bill (Enter Patient Details)");
            Console.WriteLine("2. View Last Bill");
            Console.WriteLine("3. Clear Last Bill");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your option: ");
            string choice = Console.ReadLine()??"";
            switch (choice)
            {
                case "1":
                    PatientBill.Create();
                    break;
                case "2":
                    PatientBill.View();
                    break;
                case "3":
                    PatientBill.Clear();
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