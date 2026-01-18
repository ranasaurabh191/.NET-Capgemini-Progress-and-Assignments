public class LogCache
{
    private List<LogEntry> _cache = new List<LogEntry>();

    public void Add(LogEntry entry)
    {
        _cache.Add(entry);
    }

    public void Clear()
    {
        _cache.Clear();
    }
}
