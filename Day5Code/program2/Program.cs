class Program
{
    public static void Main()
    {
        
        string make;
        string model;
        int year;
        Console.Write("Enter make of the car: ");
        make = Console.ReadLine() ?? "";
        Console.Write("Enter model of the car: ");
        model = Console.ReadLine() ?? "";
        Console.Write("Enter year of the car: ");
        year = Convert.ToInt32(Console.ReadLine());
        Car car1 = new Car(make,model,year);
        Console.WriteLine("\nCar Details: ");
        car1.DisplayDetails();
        car1.DisplayAge();
    }
}