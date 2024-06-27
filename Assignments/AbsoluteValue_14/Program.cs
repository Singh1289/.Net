using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AbsoluteValue_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value");
            int a = int.Parse(Console.ReadLine());

            if (a < 0)
            {
               a= a * (-1);
            }
            Console.WriteLine($"{a} is absolute value");
            Console.ReadKey();
        }
    }
}
