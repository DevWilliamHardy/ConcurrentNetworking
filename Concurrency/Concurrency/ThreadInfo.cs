using System;
using System.Threading;
using System.Timers;

namespace Threading
{
    
    public class Threadinfo
    {
        private int maxNum;
        private int pause;
        
        public Threadinfo(int maxNum)
        { this.maxNum = maxNum; pause = maxNum * 500; }

        public void PrintInt()
        {
            Console.WriteLine(maxNum);
            Thread.Sleep(pause);
            PrintInt();

        }
    }
}