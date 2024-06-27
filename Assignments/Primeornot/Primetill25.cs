using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeornot
{
    internal class Primetill25
    {
        public static void checkPrime25()
        {
            Console.WriteLine("Prime numbers between 1 and 25:");

            for (int number = 2; number <= 25; number++)
            {
                bool isPrime = true;

                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.Write(number + " ");
                }
            }

            Console.ReadKey();

        }
    }
}
