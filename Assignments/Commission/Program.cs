using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enetr a basic salary ");
            double bs = double.Parse(Console.ReadLine());
            Console.WriteLine($"Entered Basic Salary is {bs}");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Enetr a Sales amount ");
            double sa = double.Parse(Console.ReadLine());
            Console.WriteLine($"Entered Sales Amount is {sa}");
            Console.WriteLine("----------------------------------------------------------");
            /*  double com = 3% sa;
              Console.WriteLine(com);*/

            double hra = 20 % bs;
            double da = 40 % bs;
            double gs = bs + hra + da;
            double pf = gs * 0.10;
            double netSalary = gs - pf;
            Console.WriteLine($"The Net-Salary is calculated is {netSalary}");
            try
            {
                if( sa>5000 && sa<7500)
                { 
                    Console.WriteLine($"Commission earned on {sa} is {sa*0.03}"); 
                }
                else if( sa>7501 && sa<10500)
                {
                    Console.WriteLine($"Commission earned on {sa} is {sa * 0.08}");
                }
                else if ( sa>10501 && sa<15000)
                {
                    Console.WriteLine($"Commission earned on {sa} is {sa * 0.11}");
                }
                else if(sa>15000)
                {
                    Console.WriteLine($"Commission earned on {sa} is {sa * 0.15}");
                }
                Console.WriteLine("----------------------------------------------------------");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
