public class Program
{
    static void Main()
    {
        Console.WriteLine("=== Enterprise Log Processing System ===\n");

        using (FileLogger logger = new FileLogger("app.log"))
        {
            logger.WriteLog("Application started");
        }

        LogProcessor processor = new LogProcessor();
        processor.ProcessLogs();

        object obj = new object();
        Console.WriteLine("\nGeneration of new object: " +
            GC.GetGeneration(obj));

        Console.WriteLine("\nApplication execution completed.");
    }
}
