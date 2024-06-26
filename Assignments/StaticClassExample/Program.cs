using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Customer c1= new Customer();
            Console.WriteLine("Name : "+Customer.CustomerName);
            Console.WriteLine("Phone : "+Customer.CustomerPhone);
            Console.WriteLine("City : "+Customer.CustomerCity);
            Console.WriteLine("Country : "+Customer.GetCountry());
            Console.ReadKey();
        }
    }
}
 