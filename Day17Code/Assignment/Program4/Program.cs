using System;

namespace LogisticsApp
{
    // Base Class
    public class Shipment
    {
        public string ShipmentCode { get; set; }
        public string TransportMode { get; set; }
        public double Weight { get; set; }
        public int StorageDays { get; set; }
    }

    // Derived Class with Business Logic
    public class ShipmentDetails : Shipment
    {
        public bool ValidateShipmentCode()
        {
            // Rule: Length 6, starts with GC#, followed by 3 digits
            if (string.IsNullOrEmpty(ShipmentCode) || ShipmentCode.Length != 6) 
                return false;

            if (!ShipmentCode.StartsWith("GC#")) 
                return false;

            string numericPart = ShipmentCode.Substring(3);
            return int.TryParse(numericPart, out _);
        }

        public double CalculateTotalCost()
        {
            double ratePerKg = 0;

            switch (TransportMode)
            {
                case "Sea": ratePerKg = 15; break;
                case "Air": ratePerKg = 50; break;
                case "Land": ratePerKg = 25; break;
                default: return 0.00;
            }

            // Formula: (Weight * Rate) + Sqrt(StorageDays)
            double cost = (Weight * ratePerKg) + Math.Sqrt(StorageDays);
            return Math.Round(cost, 2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ShipmentDetails ship = new ShipmentDetails();

            Console.WriteLine("Enter the shipment code");
            ship.ShipmentCode = Console.ReadLine();

            if (ship.ValidateShipmentCode())
            {
                Console.WriteLine("Enter transport mode");
                ship.TransportMode = Console.ReadLine();

                Console.WriteLine("Enter weight");
                ship.Weight = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter storage days");
                ship.StorageDays = int.Parse(Console.ReadLine());

                Console.WriteLine($"The total shipping cost is {ship.CalculateTotalCost():F2}");
            }
            else
            {
                Console.WriteLine("Invalid shipment code");
            }
        }
    }
}
