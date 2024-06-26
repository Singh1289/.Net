using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();*/


            Console.WriteLine("Enter Size of Array");
            int a = int.Parse(Console.ReadLine());
            int[] arr2 = new int[a];

            for (int i = 0; i < a; i++)
            {
                Console.Write("Enter the value:");
                int b = int.Parse(Console.ReadLine());
                arr2[i] = b;

            }
            foreach (int i in arr2)
            {
                Console.Write(i + "\t");

            }
            Console.ReadKey();
        }
    }
}
