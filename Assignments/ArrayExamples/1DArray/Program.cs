using System;

namespace _1DArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] books = new string[5] { "Book-1", "Book-2", "Book-3", "Book-4", "Book-5"};
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine(books[i]);
            }
            Console.ReadKey();
        }
    }
}
