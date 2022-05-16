using System;

public class Actions
{
    public Result Info()
    {
        Result rez = new Result();
        rez._message = "Start method: 'Info'";
        rez._type = "Info";
        Logger newlog = Logger.Initialize;
        return rez;
    }

    public Result Warning()
    {
        Result rez = new Result();
        rez._message = "Skipped logic in method: 'Warning'";
        rez._type = "Warning";
        Logger newlog = Logger.Initialize;
        return rez;
    }

    public Result Error()
    {
        Result rez = new Result();
        rez._status = false;
        rez._message = "I broke a logic";
        rez._type = "Error";
        Logger newlog = Logger.Initialize;
        return rez;
    }
}