using System;

public class Starter
{
    void StatusCheck()
    {
        if (Status == false)
        {
            Logger.WriteDown("Action failed by a reason");
        }
    }

    public static void Run()
    {
        for (int i = 0; i < 100; i++)
        {
            int randommethod = new Random().Next(1, 3);
            Console.WriteLine(randommethod);
            switch (randommethod)
            {
                case 1:
                    Actions.Info;
                case 2:
                    Actions.Warning;
                case 3:
                    Actions.Error;

            }
        }
    }
}