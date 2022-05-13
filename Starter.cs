using System;

public class Starter
{
    public static void Run()
    {
        for (int i = 0; i < 100; i++)
        {
            int randommethod = new Random().Next(1, 3);
            switch (randommethod)
            {
                case 1:
                    Actions.Info();
                    break;
                case 2:
                    Actions.Warning();
                    break;
                case 3:
                    Actions.Error();
                    break;
            }
        }
    }
}