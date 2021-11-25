using System;
using System.Threading;

namespace Threading
{
    
    public class Threadinfo
    {
        private int num;
        private int pause;
        
        public Threadinfo(int num, int pause)
        { this.num = num; this.pause = pause; }

        public void DoWork()
        {
            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(pause);
                Console.WriteLine(num + 1);
            }
        }
    }
}