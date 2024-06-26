using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSalary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enetr a basic salary ");
            double bs = double.Parse(Console.ReadLine());
            Console.WriteLine( $"Entered Basic Salary is {bs}" );

            double hra = 20% bs;
            Console.WriteLine($"The HRA calculated is {hra}");

            double da = 40% bs;
            Console.WriteLine($"The DA calculated is {da}");

            double gs = bs + hra + da;
            Console.WriteLine($"The Gross Salary calculated is {gs}");

            //double pf = 10% gs;
            double pf = gs * 0.10;
            Console.WriteLine($"The PF calculated is {pf}");

            double netSalary = gs - pf;
            Console.WriteLine($"The Net-Salary is calculated is {netSalary}");

            Console.ReadKey();
        }
    }
}
