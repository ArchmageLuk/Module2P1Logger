using System;

public sealed class Logger
{
    private static Logger? resultlog = null;

    private Logger()
    {
        // method to write log strings into RAM
    }

    public static Logger Initialize
    {
        get
        {
            if (resultlog == null)
            {
                resultlog = new Logger();
            }

            return resultlog;
        }
    }
}
