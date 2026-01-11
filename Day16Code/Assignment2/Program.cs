using System.Collections;

class Program
{
    private static void AddNumber(ArrayList numbers,int num)
    {
        numbers.Add(num);
        Console.WriteLine("{0} added to the number list.",num);
    }
    private static void RemoveNumber(ArrayList numbers,int num)
    {
        numbers.Remove(num);
    }
    private static void DisplayNumber(ArrayList Numbers)
    {
        Console.WriteLine("Current elements in the list: ");
        foreach(var i in Numbers)
        {
            Console.WriteLine(i);
        }
    }
    static void Main()
    {
        ArrayList numbers = new ArrayList();
        while (true)
        {
            string method = Console.ReadLine()??"";
            if(method=="add" || method =="display" || method=="remove" || method == "exit")
            {
                if (method.ToLower()=="display") 
                {
                    DisplayNumber(numbers);
                    continue;
                }
                string input = Console.ReadLine()??"";
                if (!int.TryParse(input, out int number))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        continue;
                    }
                if (method.ToLower()=="exit") break;
                if (method.ToLower()=="add") AddNumber(numbers,number);
                if (method.ToLower()=="remove") RemoveNumber(numbers,number);
            }
            else
            {
                Console.WriteLine("Invalid Command");
                continue;
            }
            
        }
    }
}