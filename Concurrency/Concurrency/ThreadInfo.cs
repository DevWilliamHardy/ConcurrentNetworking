using System;
using System.Threading;
using System.Timers;

namespace Threading
{
    
    public class Threadinfo
    {
        private int minNum;
        private int maxNum;
        private int pause;

        public Threadinfo(int minNum, int maxNum, int pause)
        { this.minNum = minNum; this.maxNum = maxNum; this.pause = pause; }

        public void PrintInt()
        {
            for(int i = minNum; i < maxNum; i++)
            {
                Console.WriteLine(i);
                minNum = i;
                Thread.Sleep(pause);
            }
            if(minNum != 29)
            {
                Threadinfo info1 = new Threadinfo(minNum, maxNum += 10, 100);
                Threadinfo info2 = new Threadinfo(minNum, maxNum += 10, 100);
                Thread thread1 = new Thread(new ThreadStart(info1.PrintInt));
                Thread thread2 = new Thread(new ThreadStart(info2.PrintInt));
                thread1.Start();
                thread2.Start();
            }
            else
            {
                //Console.WriteLine();
            }




        }
    }
}