using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ForeignSales sales = new ForeignSales();
            //Sales sales=new Sales();
            Sales sales = new ForeignSales();
            Console.WriteLine($"Sales Net Profit without Gst - INR {sales.SalesNetProfit(12000, 13000, 150000)}/-");
            Console.WriteLine($"Sales Net Profit with 18% Gst - INR {sales.SalesNetProfit(12000, 13000, 150000, 18)}/-");
            //Console.WriteLine($"Sales Net Profit with 18% Gst in Dubai - INR {sales.SalesNetProfit(12000, 13000, 150000, 18, 2000)}/-");
            Console.WriteLine($"Default Gst Percent is {sales.GetGovtGstPercent()}");
            Console.WriteLine(sales.GetGstCategory());
            Console.ReadKey();
        }
    }
}
