using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxOfThree_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Three Value:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int max=MaxofthreeIF(a,b,c);
            Console.WriteLine($"max of three is { max}");

            int max2 = maxOfThreeByConditional(a,b,c);
            Console.WriteLine($"maxx of three is {max2}");
            Console.ReadKey();
        }

        private static int maxOfThreeByConditional(int a, int b, int c)
        {
            return (a>b)&&(a>c)? a : (b>c) ? b : c;
        }

        private static int MaxofthreeIF(int a, int b, int c )
        {
            if ((a > b) &&(a > c))
                 return a;
            else if (b > c)
                return b;
            else
                return c;
        }
    }
}
