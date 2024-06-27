using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] data = new int[3][];
            data[0] = new int[3] { 10, 20, 30 };
            data[1] = new int[1] { 10 };
            data[2] = new int[2] { 45, 60 };

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{i}:- ");
                for (int j = 0; j < data[i].Length; j++)
                {
                    Console.Write($"{data[i][j]}\t");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
            Console.WriteLine("Array 2");
            Console.Write("Enter no. of rows :");
            int row= int.Parse( Console.ReadLine() );
            int[][] data2 = new int[row][];

            for (int i = 0; i < row; i++)
            {
                Console.Write("enter column size :");
                int z= int.Parse( Console.ReadLine() );
                data2[i]= new int[z];
                for (int j = 0; j < z; j++)
                {
                    Console.Write("Enter value : ");
                    data2[i][j]= int.Parse( Console.ReadLine() );
                }
                
            }

            for (int i = 0; i < row; i++)
            {
                Console.Write($"{i}:- ");
                for (int j = 0; j < data2[i].Length; j++)
                {
                    Console.Write($"{data2[i][j]}\t");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();

        }
    }
}
