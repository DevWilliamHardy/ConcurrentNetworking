using System;
using System.Threading;

namespace Threading
{
    public class CountThread
    {
        private int x;
        private int y;
        public CountThread(int x, int y)
        {
            this.x = x; this.y = y; 
        }
        public void Count()
        {
            for(int i = x; i >= y; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
    public class Program
    {
        public static void Main()
        {
            CountThread count1 = new CountThread(100, 0);

            Thread thread1 = new Thread(new ThreadStart(count1.Count));
            thread1.Start();

            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }



        }
    }
}

