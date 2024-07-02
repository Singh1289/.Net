using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack books= new Stack();
            books.Push("Book-1");
            books.Push("Book-2");
            books.Push("Book-3");
            books.Push("Book-4");
            books.Peek();
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
            Console.ReadKey();
        }
    }
}
