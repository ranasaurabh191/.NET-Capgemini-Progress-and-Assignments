using System.Collections;

class Program
{
    private static bool IsValidName(string name)
    {   
        return !string.IsNullOrWhiteSpace(name);
    }
    private static bool IsNameInCollection(ArrayList studentNames, string name)
    {
        return studentNames.Contains(name);
        
    }
    private static void DisplayStudentNames(ArrayList studentNames)
    {
        Console.WriteLine("Unique student names entered:");
        foreach(var names in studentNames)
        {
            Console.WriteLine(names);
        }
    }
    static void Main()
    {
        ArrayList studentNames = new ArrayList();

        while (true)
        {
            string input = Console.ReadLine()??"";
            if (input.ToLower() == "stop")
            {
                break;
            }
            if (!IsValidName(input))
            {
                Console.WriteLine("Enter valid name.");
                continue;
            }

            if (IsNameInCollection(studentNames,input))
            {
                Console.WriteLine("{0} aleady in collection.",input);
                continue;
            }
            studentNames.Add(input);
            Console.WriteLine("{0} added to the collection.",input);
        }
        DisplayStudentNames(studentNames);
    }
    
}