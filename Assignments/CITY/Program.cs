using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CITY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mcount = 0,pcount=0, bcount=0;
            //Object Initializer
            //Customer customer=new Customer() { CustomerId= 1 };
            foreach (Customer customer in GetAllCustomers())
            {
                Console.WriteLine($"Customer {customer.ContactName} lives in city {customer.City}!");
                if (customer.City.Equals("Mumbai"))
                {
                    mcount++;
                }
                if (customer.City.Equals("Pune"))
                {
                    pcount++;
                }
                if (customer.City.Equals("Bangalore"))
                {
                    bcount++;
                }

            }

            Console.WriteLine($"{mcount} Customer lives in Mumbai");
            Console.WriteLine($"{pcount} Customer lives in Pune");
            Console.WriteLine($"{bcount} Customer lives in Bangalore");
            Console.ReadKey();
        }
        private static List<Customer> GetAllCustomers()
        {
            return new List<Customer>()
            {
                new Customer(){ CustomerId=100,ContactName="Alisha C.",City="Mumbai" },
                new Customer(){ CustomerId=101,ContactName="Manisha K.",City="Mumbai" },
                new Customer(){ CustomerId=102,ContactName="Pravinkumar R. D.",City="Pune" },
                new Customer(){ CustomerId=103,ContactName="Manish Kaushik",City="Bangalore" },
                new Customer(){ CustomerId=103,ContactName="Manish Kaushik",City="Pune" },
            };
        }
    }
}
