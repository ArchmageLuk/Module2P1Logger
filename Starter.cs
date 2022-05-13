using System;

public class Starter
{
    public static void Run()
    {
        for (int i = 0; i < 100; i++)
        {
            int randommethod = new Random().Next(1, 4);
            switch (randommethod)
            {
                case 1:
                    var info = Actions.Info();
                    Console.WriteLine(info._message);
                    break;
                case 2:
                    var warning = Actions.Warning();
                    Console.WriteLine(warning._message);
                    break;
                case 3:
                    var error = Actions.Error();
                    Console.WriteLine(error._message);

                    if (error._status == false)
                    {
                        error._message = "Action failed by a reason:" + error._message;
                        _ = Logger.Initialize;
                    }

                    break;
            }
        }
    }
}