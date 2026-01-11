
public class Program
{
    public static void Main()
    {
    
        string input = Console.ReadLine()??"";

        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        var sortedWords = words.Select((word, index) => new { word, index }).OrderByDescending(x => x.word.Length).ThenBy(x => x.index).Select(x => x.word);

        Console.WriteLine(string.Join(" ", sortedWords));
    }
}
