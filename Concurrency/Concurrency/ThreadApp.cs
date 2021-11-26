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
            Threadinfo info1 = new Threadinfo(101, 100);
            Threadinfo info2 = new Threadinfo(100, 100);

            Thread countDown = new Thread(new ThreadStart(info2.Decrease));
            Thread countUp = new Thread(new ThreadStart(info1.Increase));

            countDown.Start();
            countUp.Start();
        }
    }
}
