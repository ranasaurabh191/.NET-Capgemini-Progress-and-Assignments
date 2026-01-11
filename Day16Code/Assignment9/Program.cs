using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            string input = Console.ReadLine() ?? "";

            string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int[] numbers = parts.Select(p => int.Parse(p)).ToArray();

            var result = numbers
                .Select(n => n * n)
                .OrderBy(n => n)
                .ToArray();
      
            Console.WriteLine(string.Join(" ", result));
        }
        catch
        {
            Console.WriteLine("Invalid input");
        }
    }
}
