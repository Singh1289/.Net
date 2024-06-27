using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ASCIIFrom0_255_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j = 9;
            for (int i = 0; i < 256; i++)
            {
                Console.Write(Convert.ToChar(i)+"\t");
                if (i == j) 
                {
                    Thread.Sleep(2000);
                    j += 10;
                    Console.WriteLine(  );
                }
            }
            Console.ReadKey();
        }

    }
}
