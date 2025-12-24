class Program
{
    static void Main()
    {
        Console.Write("Enter 1 for car, 2 for truck, 3 for bike: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        int days,distance;
        bool includeInsurance,withDriver;
        VehicleRentalEstimator vre = new VehicleRentalEstimator();

        switch (choice)
        {
            case 1: 
            Console.Write("Enter days: ");
            days = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter distance: ");
            distance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The estimated rental cost of the car is: $"+vre.EstimateCost(days,distance));
            break;

            case 2:
            Console.Write("Enter days: ");
            days = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter distance: ");
            distance = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter WithDriver: ");
            withDriver = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("The estimated rental cost of the car is: $"+vre.EstimateCost(days,distance,withDriver));
            break;

            case 3:
            Console.Write("Enter days: ");
            days = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter includeInsurance: ");
            includeInsurance = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("The estimated rental cost of the car is: $"+vre.EstimateCost(days,includeInsurance));
            break;

            default:
            Console.WriteLine("Invalid");
            break;

        }

    }
}