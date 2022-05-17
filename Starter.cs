using System;
using System.Text;

public class Starter
{
    public void Run()
    {
        string[] wholelog = new string[100];
        for (int i = 0; i < 100; i++)
        {
            int randommethod = new Random().Next(1, 4);
            void GetLog(Result whatmethod) // Method to use fields in the result object to create log, show it on console and write it down
            {
                string log = $"{i}: {whatmethod._time}: {whatmethod._type}: {whatmethod._message}" + Environment.NewLine;
                Console.WriteLine(log);
                wholelog[i] = log;

                // using (StreamWriter writer = new StreamWriter("log.txt", true)) //// true to append data to the file
                // {
                // writer.WriteLine(log);
                // }
            }

            if (randommethod == 1)
            {
                var result = new Actions();
                var resultlog = result.Info();
                GetLog(resultlog);
            }

            if (randommethod == 2)
            {
                var result = new Actions();
                var resultlog = result.Warning();
                GetLog(resultlog);
            }

            if (randommethod == 3)
            {
                var result = new Actions();
                var resultlog = result.Error();
                if (resultlog._status == false)
                {
                        resultlog._message = new string("Action failed by a reason: " + resultlog._message);
                }

                GetLog(resultlog);
            }
        }

        File.WriteAllLines("log.txt", wholelog);
    }
}