using System.ComponentModel;

class Program
{
    public static void Main()
    {
        Console.Write("Enter string: ");
        string input = Console.ReadLine() ?? "";
        Console.Write("Enter choice 1,2,3: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        StringConverter str1 = new StringConverter();

        switch (choice)
        {
            case 1:
                Console.WriteLine(str1.ConvertString(input));
                break;

            case 2:
                Console.WriteLine(str1.ConvertString(input, true));
                break;
            case 3:
                Console.WriteLine(str1.ConvertString(input,1));
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
    
        }

    }
}