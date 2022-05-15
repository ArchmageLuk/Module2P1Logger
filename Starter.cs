using System;
using System.Text;

public class Starter
{
    public static void Run()
    {
        for (int i = 0; i < 100; i++)
        {
            int randommethod = new Random().Next(1, 4);
            void GetLog(Result whatmethod) // Method to use fields in the result object to create log, show it on console and write it down
            {
                string log = $"{i}: {whatmethod._time}: {whatmethod._type}: {whatmethod._message}" + Environment.NewLine;
                Console.WriteLine(log);
                File.WriteAllText("log.txt", log);
            }

            if (randommethod == 1)
            {
                var resultlog = Actions.Info();
                GetLog(resultlog);
            }

            if (randommethod == 2)
                {
                    var resultlog = Actions.Warning();
                    GetLog(resultlog);
                }

            if (randommethod == 3)
                {
                    var resultlog = Actions.Error();
                    if (resultlog._status == false)
                    {
                        resultlog._message = new string("Action failed by a reason: " + resultlog._message);
                    }

                    GetLog(resultlog);
                }
        }
    }
}