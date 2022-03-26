using System;
using System.Threading;

namespace Threading
{
    public class Threadinfo
    {
        private int x;
        public Threadinfo(int x)
            { this.x = x; }
        public void Position()
        {
            Console.WriteLine(x);
            Thread.Sleep((int)((x + 100) * .50));
            Position();
        }
    }
    public class Program
    {
        public static void Main()
        {
            Threadinfo info1 = new Threadinfo(0);
            Threadinfo info2 = new Threadinfo(1);
            Threadinfo info3 = new Threadinfo(2);
            Threadinfo info4 = new Threadinfo(3);
            Threadinfo info5 = new Threadinfo(4);

            Thread thread1 = new Thread(new ThreadStart(info1.Position));
            Thread thread2 = new Thread(new ThreadStart(info2.Position));
            Thread thread3 = new Thread(new ThreadStart(info3.Position));
            Thread thread4 = new Thread(new ThreadStart(info4.Position));
            Thread thread5 = new Thread(new ThreadStart(info5.Position));

            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();
            thread5.Start();


        }
    }
}
