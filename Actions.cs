using System;

public class Actions
{
    public static Result Info()
    {
        Result rez = new Result();
        rez._status = true;
        rez._time = DateTime.UtcNow.AddHours(3);
        rez._message = "Start method: 'Info'";
        rez._type = "Info";
        Logger newlog = Logger.Initialize;
        return rez;
    }

    public static Result Warning()
    {
        Result rez = new Result();
        rez._status = true;
        rez._time = DateTime.UtcNow.AddHours(3);
        rez._message = "Skipped logic in method: 'Warning'";
        rez._type = "Warning";
        Logger newlog = Logger.Initialize;
        return rez;
    }

    public static Result Error()
    {
        Result rez = new Result();
        rez._status = false;
        rez._time = DateTime.UtcNow.AddHours(3);
        rez._message = "I broke a logic";
        rez._type = "Error";
        Logger newlog = Logger.Initialize;
        return rez;
    }
}