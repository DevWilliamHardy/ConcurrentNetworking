using System;
using System.Threading;
using System.Diagnostics; //for Stopwatch


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Processor Count is {0}\n", Environment.ProcessorCount);
        Stopwatch stopwatch = new Stopwatch();

        int[] x = new int[30];
        int val = 0;
        Thread thread;
        Console.WriteLine(x.Length);
        stopwatch.Start();
        for (int i = 0; i < x.Length; i++)
        {
            x[i] = i;
            thread = new Thread(DoMath);
            thread.Start(x[i]);
        }
        for (int i = 0; i < x.Length; i++)
        {
            //thread.Join();
            //Console.WriteLine("HELLO");
        }
        stopwatch.Stop();
        Console.WriteLine("Time taken for Fibonacci of {0} and {1} synchronously is {2} secs",
                                 40, 41, stopwatch.ElapsedMilliseconds / 1000);

        Console.ReadLine();
    }
       
        static void DoMath(object n)
    {
        int _n = (int)n;
        Console.WriteLine("Fibonacci of {0} is {1}; Thead ID {2}",
            _n, Fibonacci(_n).ToString(), Thread.CurrentThread.ManagedThreadId);

    }

    static long Fibonacci(int x)
    {
        if (x <= 1)
            return 1;
        return Fibonacci(x - 1) + Fibonacci(x - 2);
    }
        
}