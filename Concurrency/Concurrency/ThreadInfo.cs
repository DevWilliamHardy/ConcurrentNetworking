using System;
using System.Threading;

namespace Threading
{
    
    public class Threadinfo
    {
        private int maxNum;
        private int pause;
        
        public Threadinfo(int maxNum, int pause)
        { this.maxNum = maxNum; this.pause = pause; }

        public void Decrease()
        {
            for (int i = maxNum; i > 0; i--)
            {
                Thread.Sleep(pause);
                Console.WriteLine(maxNum -= 1);
            }
        }
        public void Increase()
        {
            int x = maxNum;
            for(int i = 0; i < x; i++)
            {
                Thread.Sleep(pause);
                Console.WriteLine(i);
            }
        }
    }
}