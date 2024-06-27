using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeornot
{
    internal class UserCheckPrime
    {
        public static void checkPrime() {
            Console.WriteLine("Enter a Number");
            int n = int.Parse(Console.ReadLine());

            int c = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    c++;
            }
            if (c == 2)
            {
                Console.WriteLine($"{n} is Prime Number");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"{n} is not Prime Number");
                Console.ReadKey();
            }
        }
    }
}
