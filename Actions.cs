using System;


public class Actions
{
    public static Result Info()
    {
        Result rez = new Result();
        rez.status = true;
        rez.message = "Start method: Info";

        return rez;
    }

    public static Result Warning()
    {
        Result rez = new Result();
        rez.status = true;
        rez.message = "Skipped logic in method: Warning";
        return rez;
    }

    public static Result Error()
    {
        Result rez = new Result();
        rez.status = false;
        rez.message = "I broke a logic";
        return rez;
    }
}

public class Result
{
    public bool status;
    public string? message;
}

