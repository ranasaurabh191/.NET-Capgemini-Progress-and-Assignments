using System;
using System.Collections.Generic;
using System.IO;

public class LogEntry
{
    public string Message { get; set; }
    public DateTime CreatedAt { get; set; }

    public LogEntry(string message)
    {
        Message = message;
        CreatedAt = DateTime.Now;
    }
}
