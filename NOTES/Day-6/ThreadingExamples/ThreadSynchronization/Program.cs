using System;
using System.Threading;

namespace ThreadSynchronization
{
    internal class Program
    {
        static object o=new object();
        static int TicketNo = 1;
        static void Main(string[] args)
        {
            Console.WriteLine($"Main Thread is running on Thread Id - {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine("Main Thread Started!");
            Thread t1 = new Thread(new ThreadStart(TicketWindow1));
            Thread t2 = new Thread(new ThreadStart(TicketWindow2));
            //t1.Priority = ThreadPriority.Lowest;
            //t2.Priority = ThreadPriority.Highest;
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();

            Console.WriteLine("Main Thread Ended!");
        }
        private static void TicketWindow1()
        {
            Monitor.Enter(o);
            //lock (o)
            //{
                Console.WriteLine($"Window-1 Thread is running on Thread Id - {Thread.CurrentThread.ManagedThreadId}");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Window - 1 and Step - {TicketNo}");
                    TicketNo++;
                    Thread.Sleep(1000);
                }
            //}
            Monitor.Exit(o);
            
        }
        private static void TicketWindow2()
        {
            
            lock (o)
            {
                Console.WriteLine($"Window-2 Thread is running on Thread Id - {Thread.CurrentThread.ManagedThreadId}");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Window - 2 and Step - {TicketNo}");
                    TicketNo++;
                } 
            }
        }
    }
}
