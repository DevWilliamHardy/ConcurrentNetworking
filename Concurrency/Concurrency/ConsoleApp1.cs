using System;
using System.Threading;
using System.Diagnostics;
namespace ConsoleApp1
{
    class Program
    {
        static bool useLock = true;
        static object locker = new object();
        static int threadCount = 1000;
        static int a;
        int total = 5;

        private static Semaphore _pool;

        static void Main(string[] args)
        {
            while (true)
            {

                _pool = new Semaphore(0, 2);
                useLock = !useLock;
                a = 0;
                Thread[] threads = new Thread[threadCount];

                for (int i = 0; i < threadCount; i++)
                {
                    threads[i] = new Thread(new ThreadStart((new Counting()).add));
                }

                for (int i = 0; i < threadCount; i++)
                {
                    threads[i].Start();
                }
                Thread.Sleep(500);

                for (int i = 0; i < threadCount; i++)
                {
                    Console.WriteLine("Main Thread Calls Release (3). ");
                    _pool.Release(3);
                }
                Console.WriteLine("Main thread exits.");

                Console.WriteLine("A lock was used = " + useLock);
                Console.WriteLine("Final = " + a);
                Thread.Sleep(5000);
                Console.Clear();
            }
        }

        public class Counting
        {
            public void add()
            {
                if (useLock)
                {
                    lock (locker)
                    {
                        int b = a + 1;
                        Console.WriteLine(a);
                        a = b;
                        _pool.WaitOne();
                    }
                }
                else
                {
                    int b = a + 1;
                    Console.WriteLine(a);
                    a = b;
                    _pool.WaitOne();
                }
            }
        }
    }
}
