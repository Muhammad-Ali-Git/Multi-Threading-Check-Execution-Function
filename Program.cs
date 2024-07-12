using System;
using System.Threading;

class Ali
{
    public static void Main()
    {
        Console.WriteLine("This program prints the output of a multi-threaded program that runs concurrently with the Main thread.");
        Console.WriteLine("-------------------------------------------------------------------------------------------------------");

        Console.WriteLine("Main Started.");
        Console.WriteLine("-------------------------------------------------------------------------------------------------------");

        Thread T = new Thread(ThreadFunction);
        T.Start();

        for (int i = 1; i <= 10; i++)
        {
            if (T.IsAlive)
            {
                Console.WriteLine("Thread is still Executing after {0}ms", i);
                Thread.Sleep(i);  // To Check Every 100ms
            }
            else
            {
                Console.WriteLine("Thread Executed Successfullly.");
                break;
            }
        }

        Console.WriteLine("-------------------------------------------------------------------------------------------------------");

        Console.WriteLine("Main Ended.");
    }

    public static void ThreadFunction()
    {
        Console.WriteLine("Thread Function Print");
    }
}