using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Threading;

namespace Concurrency
{
    class ThreadApp
    {
        public static void Main()
        {
            Threadinfo info1 = new Threadinfo(1);
            Threadinfo info2 = new Threadinfo(2);
            Threadinfo info3 = new Threadinfo(3);
            Threadinfo info4 = new Threadinfo(4);
            Threadinfo info5 = new Threadinfo(5);
            

            Thread thread1 = new Thread(new ThreadStart(info1.PrintInt));
            Thread thread2 = new Thread(new ThreadStart(info2.PrintInt));
            Thread thread3 = new Thread(new ThreadStart(info3.PrintInt));
            Thread thread4 = new Thread(new ThreadStart(info4.PrintInt));
            Thread thread5 = new Thread(new ThreadStart(info5.PrintInt));

            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();
            thread5.Start();
        }
    }
}
