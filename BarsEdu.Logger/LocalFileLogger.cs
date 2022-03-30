public class LocalFileLogger<T> : ILogger
{
    public LocalFileLogger(string path)
    {
        this.path = path;
    }

    private readonly string path;

    public void LogError(string message, Exception ex)
    {
        WriteToFile($"[Error]: [{typeof(T).Name}] : {message}. {ex.Message}");
    }

    public void LogInfo(string message)
    {
        WriteToFile($"[Info]: [{typeof(T).Name}] : {message}");
    }

    public void LogWarning(string message)
    {
        WriteToFile($"[Warning]: [{typeof(T).Name}] : {message}");
    }

    private void WriteToFile(string message)
    {
        try
        {
            using (var writer = new StreamWriter(path, true))
            {
                writer.WriteLine(message);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
