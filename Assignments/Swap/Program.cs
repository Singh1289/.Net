using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a value");

            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter a value");

            int b = int.Parse(Console.ReadLine());

            int temp;

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"value of a is {a}");
            Console.WriteLine($"value of b is {b}");

        }
    }
}
