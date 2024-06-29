using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SimpleThreadingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Main Thread is running on Thread Id - {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine("Main Thread Started!");
            Thread t1 = new Thread(new ThreadStart(Job1));
            Thread t2 = new Thread(new ThreadStart(Job2));
            t1.Priority=ThreadPriority.Lowest; 
            t2.Priority=ThreadPriority.Highest;
            t2.Start();
            t1.Start();
            t1.Join();
            t2.Join();
            
            Console.WriteLine("Main Thread Ended!");
        }
        private static void Job1()
        {
            Console.WriteLine($"Job-1 Thread is running on Thread Id - {Thread.CurrentThread.ManagedThreadId}");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Job - 1 and Step - {i}");
            }
        }
        private static void Job2()
        {
            Console.WriteLine($"Job-2 Thread is running on Thread Id - {Thread.CurrentThread.ManagedThreadId}");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Job - 2 and Step - {i}");
            }
        }
    }
}
