using System;

public class Result
{
    public bool WhatStatus
    {
        get
        {
            bool status = true;
        }

    }
}

public class Actions
{
    public void Info()
    {
        var message = "Start method Info";
        Logger.WriteDown(message);
        return Result;
    }

    public void Warning()
    {
        return Result;
    }

    public void Error()
    {
        return Result;
    }
}
