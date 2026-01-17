using LogProcessing;
class Program
{
    static void Main()
    {
        LogParser parser = new LogParser();

        Console.WriteLine("TASK 1: Validate Log Line");
        Console.WriteLine(parser.IsValidLine("[INF] Application started"));   // true
        Console.WriteLine(parser.IsValidLine("INF Application started"));     // false
        Console.WriteLine();

        Console.WriteLine("TASK 2: Split Log Line");
        string logLine = "[INF] User login<***>Session created<====>Access granted";
        string[] splitResult = parser.SplitLogLine(logLine);

        foreach (string part in splitResult)
        {
            Console.WriteLine(part);
        }
        Console.WriteLine();


        Console.WriteLine("TASK 3: Count Quoted Passwords");
        string logText =
            "User said \"password123 is weak\"\n" +
            "Admin noted \"PASSWORD456 expired\"\n" +
            "No issue found";

        Console.WriteLine(parser.CountQuotedPasswords(logText)); // 2
        Console.WriteLine();

        Console.WriteLine("TASK 4: Remove End-of-Line Marker");
        string lineWithMarker = "Transaction completed successfully end-of-line456";
        Console.WriteLine(parser.RemoveEndOfLineText(lineWithMarker));
        Console.WriteLine();

        Console.WriteLine("TASK 5: Label Weak Passwords");
        string[] lines =
        {
            "User entered password123 during login",
            "System startup completed",
            "Admin reset passwordABC",
            "Backup process finished"
        };

        string[] result = parser.ListLinesWithPasswords(lines);
        foreach (string r in result)
        {
            Console.WriteLine(r);
        }
    }
}
