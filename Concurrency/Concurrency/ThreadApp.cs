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
            int threadCount = 0;

            Thread t1 = new Thread(() =>
            {
                int number = 0;
                while (number < 9)
                {
                    Thread.Sleep(100);

                    number++;
                    Console.WriteLine(number);
                }
                threadCount += 1;

                Thread t2 = new Thread(() =>
                {
                    int number = 9;
                    while (number < 19)
                    {
                        Thread.Sleep(100);

                        number++;
                        Console.WriteLine(number);
                    }
                    threadCount += 1;
                    Thread t4 = new Thread(() =>
                    {
                        int number = 19;
                        while (number < 29)
                        {
                            Thread.Sleep(100);

                            number++;
                            Console.WriteLine(number);
                        }
                        threadCount += 1;
                    });
                    t4.Start();
                    Thread t5 = new Thread(() =>
                    {
                        int number = 19;
                        while (number < 29)
                        {
                            Thread.Sleep(100);

                            number++;
                            Console.WriteLine(number);
                        }
                        threadCount += 1;
                    });
                    t5.Start();
                    t4.Join();
                    t5.Join();
                });
                t2.Start();
                Thread t3 = new Thread(() =>
                {
                    int number = 9;
                    while (number < 19)
                    {
                        Thread.Sleep(100);

                        number++;
                        Console.WriteLine(number);
                    }
                    threadCount += 1;
                    Thread t6 = new Thread(() =>
                    {
                        int number = 19;
                        while (number < 29)
                        {
                            Thread.Sleep(100);

                            number++;
                            Console.WriteLine(number);
                        }
                        threadCount += 1;
                    });
                    t6.Start();
                    Thread t7 = new Thread(() =>
                    {
                        int number = 19;
                        while (number < 29)
                        {
                            Thread.Sleep(100);

                            number++;
                            Console.WriteLine(number);
                        }
                        threadCount += 1;
                    });
                    t7.Start();
                    t6.Join();
                    t7.Join();
                });
                t3.Start();
                t2.Join();
                t3.Join();
            });




            t1.Start();

            t1.Join();



            Console.WriteLine("Threads Used {0}", (threadCount));

        }
    }
}
