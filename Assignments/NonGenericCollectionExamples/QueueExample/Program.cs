using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue tickets= new Queue();
            tickets.Enqueue(1000);
            tickets.Enqueue(1001);
            tickets.Enqueue(1002);
            foreach (var ticketNo in tickets)
            {
                Console.WriteLine(ticketNo);
            }
        }
    }
}
