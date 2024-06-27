using System;

namespace _2DArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] arr = new int[2,5]{{1,2,3,4,5},{7,8,9,4,5}};

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{arr[i,j]}\t");
                }
                Console.WriteLine("");
            }

            Console.ReadKey();

            Console.WriteLine("Enter Size of Array");
            int a = int.Parse(Console.ReadLine());
            int[,] arr2 = new int[a, a];

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write("Enter the value:");
                    int b = int.Parse(Console.ReadLine());
                    arr2[i,j] = b;
                }
            }
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write($"{arr2[i, j]}\t");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
