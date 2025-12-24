class Program
{
    public static void Main()
    {
        string name,address;
        int age;
        Console.Write("Enter name: ");
        name = Console.ReadLine() ?? "";
        Console.Write("Enter age: ");
        age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Address: ");
        address = Console.ReadLine() ?? "";
        Person person = new Person(name,age,address);

        Console.WriteLine("\nPersons Information: ");
        person.DisplayDetails();
    }
}