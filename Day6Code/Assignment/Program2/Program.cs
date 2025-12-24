class Program
{
    static void Main()
    {
        Console.Write("Enter Men ID: ");
        int menId = int.Parse(Console.ReadLine()??"");
        Console.Write("Enter Men Size: ");
        int menSize = int.Parse(Console.ReadLine()??"");

        Console.Write("Enter Women ID: ");
        int womenId = int.Parse(Console.ReadLine()??"");
        Console.Write("Enter Women Size: ");
        int womenSize = int.Parse(Console.ReadLine()??"");
        Console.Write("Enter material: ");
        string material = Console.ReadLine() ?? "";

        Console.Write("Enter Kids ID: ");
        int kidId = int.Parse(Console.ReadLine()??"");
        Console.Write("Enter Kids Size: ");
        int kidSize = int.Parse(Console.ReadLine()??"");

        Men men = new Men(menId, menSize);
        Women women = new Women(womenId, womenSize, material);
        Kids kid = new Kids(kidId, kidSize);

        men.DisplayInfo();
        women.DisplayInfo();
        kid.DisplayInfo();
    }
}