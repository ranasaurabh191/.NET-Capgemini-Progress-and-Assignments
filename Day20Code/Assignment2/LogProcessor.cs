public class LogProcessor
{
    private LogCache _cache;
    private WeakReference _weakCacheRef;

    public void ProcessLogs()
    {
        Console.WriteLine("\n--- Log Processing Started ---");

        long memoryBefore = GC.GetTotalMemory(false);
        Console.WriteLine($"Initial Memory: {memoryBefore} bytes");

        _cache = new LogCache();
        _weakCacheRef = new WeakReference(_cache);

        for (int i = 0; i < 10000; i++)
        {
            _cache.Add(new LogEntry("Log entry " + i));
        }

        long memoryAfterCreation = GC.GetTotalMemory(false);
        Console.WriteLine($"Memory After Log Creation: {memoryAfterCreation} bytes");

        _cache.Clear();
        _cache = null;

        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();

        long memoryAfterGC = GC.GetTotalMemory(true);
        Console.WriteLine($"Memory After GC: {memoryAfterGC} bytes");

        Console.WriteLine("Is Cache Alive (WeakReference): " +
            _weakCacheRef.IsAlive);
    }
}
