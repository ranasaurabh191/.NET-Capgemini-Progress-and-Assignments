using System;
using System.Collections.Generic;

public class Program
{
    private static List<int> ParseIntegers(string input)
    {
        List<int> result = new List<int>();

        if (string.IsNullOrWhiteSpace(input))
            return result;

        string[] tokens = input.Split(' ');
        
        foreach (string token in tokens)
        {
            if (int.TryParse(token, out int value))
            {
                result.Add(value);
            }
        }
        return result;
    }

    private static List<int> GetOddNumbers(List<int> numbers)
    {
        List<int> oddNumbers = new List<int>();
        foreach (int num in numbers)
        {
            if (num % 2 != 0)
            {
                oddNumbers.Add(num);
            }
        }
        oddNumbers.Sort(); 
        return oddNumbers;
    }
    public static void Main()
    {
        string input = Console.ReadLine();
        List<int> numbers = ParseIntegers(input);
        List<int> oddNumbers = GetOddNumbers(numbers);
        if (oddNumbers.Count > 0)
        {
            Console.WriteLine(string.Join(" ", oddNumbers));
        }
    }
}
