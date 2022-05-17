using System;

public class Actions
{
    public Result CallResult(bool status, string type, string message)
    {
        Result rez = new Result();
        rez._status = status;
        rez._message = message;
        rez._type = type;
        Logger newlog = Logger.Initialize;
        return rez;
    }

    public Result Info()
    {
        var rez = CallResult(true, "Info", "Start method: 'Info'");
        return rez;
    }

    public Result Warning()
    {
        var rez = CallResult(true, "Warning", "Skippen logic in method: 'Warning'");
        return rez;
    }

    public Result Error()
    {
        var rez = CallResult(false, "Error", "I broke a logic");
        return rez;
    }
}