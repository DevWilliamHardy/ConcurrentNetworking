using System;
using System.Threading;

namespace Threading
{
    public class Threadinfo
    {
        private int x, y, threadCount;

        public Threadinfo(int x, int y, int threadCount)
            { this.y = y; this.x = x; this.threadCount = threadCount; }

        public void Count()
        {
            if(!(x >= 29 | y > 29))
            {
                for (int i = x; i <= y; i++)
                {
                    Console.WriteLine(i.ToString());
                }
                threadCount += 2;
                Threadinfo info1 = new Threadinfo(y, y + 10, threadCount);
                Threadinfo info2 = new Threadinfo(y, y + 10, threadCount);

                Thread thread1 = new Thread(new ThreadStart(info1.Count));
                Thread thread2 = new Thread(new ThreadStart(info2.Count));

                thread1.Start();
                thread2.Start();

                thread1.Join();
                thread2.Join();
            }

            Console.WriteLine(threadCount.ToString());
        }
    }

    public class Program
    {
        public static void Main()
        {
            Threadinfo info1 = new Threadinfo(0, 9, 1);
            Thread thread1 = new Thread(new ThreadStart(info1.Count));
            thread1.Start();
        }
    }
}