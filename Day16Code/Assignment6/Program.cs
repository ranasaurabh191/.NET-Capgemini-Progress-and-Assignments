
public class Program
{
    public static void AddString(HashSet<string> set)
    {
        Console.Write("Enter the string to add: ");
        string value = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(value))
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        if (set.Add(value))
        {
            Console.WriteLine($"'{value}' has been added.");
        }
        else
        {
            Console.WriteLine($"'{value}' already exists in the set.");
        }
    }

    public static void DisplayStrings(HashSet<string> set)
    {
        Console.WriteLine("Current items in the set:");

        if (set.Count == 0)
        {
            Console.WriteLine("Nothing in the set.");
            return;
        }

        foreach (string item in set)
        {
            Console.WriteLine(item);
        }
    }

    public static void UpdateString(HashSet<string> set)
    {
        Console.Write("Enter the string to update: ");
        string oldValue = Console.ReadLine();

        if (!set.Contains(oldValue))
        {
            Console.WriteLine($"'{oldValue}' does not exist in the set.");
            return;
        }

        Console.Write("Enter the new string: ");
        string newValue = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(newValue))
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        if (set.Contains(newValue))
        {
            Console.WriteLine($"Update failed. '{newValue}' already exists in the set.");
            return;
        }

        set.Remove(oldValue);
        set.Add(newValue);

        Console.WriteLine($"'{oldValue}' has been updated to '{newValue}'.");
    }

    public static void DeleteString(HashSet<string> set)
    {
        Console.Write("Enter the string to delete: ");
        string value = Console.ReadLine();

        if (set.Remove(value))
        {
            Console.WriteLine($"'{value}' has been removed.");
        }
        else
        {
            Console.WriteLine($"'{value}' does not exist in the set.");
        }
    }
    public static void Main()
    {
        HashSet<string> stringSet = new HashSet<string>();

        while (true)
        {
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1: Create (Add a new string)");
            Console.WriteLine("2: Read (Display all strings)");
            Console.WriteLine("3: Update (Update an existing string)");
            Console.WriteLine("4: Delete (Remove a string)");
            Console.WriteLine("5: Exit");

            Console.Write("Enter your choice: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int choice))
            {
                Console.WriteLine("Invalid choice.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    AddString(stringSet);
                    break;

                case 2:
                    DisplayStrings(stringSet);
                    break;

                case 3:
                    UpdateString(stringSet);
                    break;

                case 4:
                    DeleteString(stringSet);
                    break;

                case 5:
                    Console.WriteLine("Exiting...");
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
