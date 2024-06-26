using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] marks = new int[3][];
            marks[0] = new int[3] { 100, 200, 300 };
            marks[1] = new int[5] { 100, 200, 300, 400, 500 };
            marks[2] = new int[2] { 780, 980 };

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Row Number is {i}");
                for (int j = 0; j < marks[i].Length; j++)
                {
                    Console.Write($"Col - {j} - {marks[i][j]}\t");
                }
                Console.WriteLine("");
            }
        }
    }
}
