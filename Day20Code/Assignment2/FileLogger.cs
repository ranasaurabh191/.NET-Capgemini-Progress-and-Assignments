public class FileLogger : IDisposable
{
    private StreamWriter _writer;
    private bool disposed = false;

    public FileLogger(string filePath)
    {
        _writer = new StreamWriter(filePath, true);
        Console.WriteLine("File resource acquired.");
    }

    public void WriteLog(string message)
    {
        _writer.WriteLine($"{DateTime.Now}: {message}");
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                _writer?.Dispose();
                Console.WriteLine("Managed resources released.");
            }

            Console.WriteLine("Unmanaged resources released.");
            disposed = true;
        }
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
        Console.WriteLine("FileLogger disposed.");
    }

    ~FileLogger()
    {
        Dispose(false);
    }
}
