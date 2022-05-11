
public sealed class Logger
{
    private static Logger instance = null;

    private Logger()
    {

    }

    public static Logger Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }
    }
}

var message = Logger.WriteDown();

var log_type = ;

var log_time = DateTime.UtcNow.AddHours(3);

Console.Write(log_time);

var resultlog = $"{log_time}: {log_type}: {message}";

Console.WriteLine(resultlog);

File.WriteAllText("log.txt", resultlog);