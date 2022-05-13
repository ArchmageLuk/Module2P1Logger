using System;

public class Actions
{
    public static Result Info()
    {
        Result rez = new Result();
        rez._status = true;
        rez._message = "Start method: Info";
        return rez;
    }

    public static Result Warning()
    {
        Result rez = new Result();
        rez._status = true;
        rez._message = "Skipped logic in method: Warning";
        return rez;
    }

    public static Result Error()
    {
        Result rez = new Result();
        rez._status = false;
        rez._message = "I broke a logic";
        return rez;
    }
}