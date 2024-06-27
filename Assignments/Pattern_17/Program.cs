using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for(int j = i; j < j*2; j++)
                    Console.Write(j);

            }
            Console.ReadKey();
        }
    }
}
