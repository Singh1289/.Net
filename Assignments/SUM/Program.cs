using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Marks of 5 subject");
            Console.WriteLine("Subject 1");
            int s1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Subject 2");
            int s2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Subject 3");
            int s3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Subject 4");
            int s4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Subject 5");
            int s5 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Student : {name} having marks in 5 subjects as ");
            Console.WriteLine($"Subject 1 : {s1}");
            Console.WriteLine($"Subject 2 : {s2}");
            Console.WriteLine($"Subject 3 : {s3}");
            Console.WriteLine($"Subject 4 : {s4}");
            Console.WriteLine($"Subject 5 : {s5}");

            double sum = (s1 + s2 + s3 + s4 + s5);
            Console.WriteLine($"Sum of the marks of student : {name} is {sum}");

            Console.ReadKey();
        }
    }
}
