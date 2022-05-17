using System;

// Known problems
// 1. Writes only last log into the file
// 2. File "Logger" does not participate (basically performs no function)
// 3. Some mild code duplication
public class Program
{
    private static void Main()
    {
        var startlog = new Starter();
        startlog.Run();

        // Calls method Run in Starter file
    }
}