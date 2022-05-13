using System;

public sealed class Logger
{
    private static Logger single = null;

    private Logger()
    {
        // We need 3 variables - message, type and time
        string message;
        string log_type;
        var log_time = DateTime.UtcNow.AddHours(3);
        void WriteDown()
        {
            // Constructing the complete message for the log
            var resultlog = $"{log_time}: {log_type}: {message}";

            Console.WriteLine(resultlog);

            // Writing down the log message in the file
            File.WriteAllText("log.txt", resultlog);
        }
    }

    public static Logger Initialize
    {
        get
        {
            if (single == null)
            {
                single = new Logger();
            }

            return single;
        }
    }
}
