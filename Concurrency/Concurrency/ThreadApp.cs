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
            Threadinfo info1 = new Threadinfo(100, 100);
            Threadinfo info2 = new Threadinfo(0, 200);

            Thread thread1 = new Thread(new ThreadStart(info1.DoWork));
            Thread thread2 = new Thread(new ThreadStart(info2.DoWork));
            thread1.Start();
            thread2.Start();
        }
    }
}
