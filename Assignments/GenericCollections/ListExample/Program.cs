using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Object Initializer
            //Customer customer=new Customer() { CustomerId= 1 };
            foreach (Customer customer in GetAllCustomers())
            {
                Console.WriteLine($"Customer {customer.ContactName} lives in city {customer.City}!");
            }
            
        }
        private static List<Customer> GetAllCustomers()
        {
            return new List<Customer>() 
            {
                new Customer(){ CustomerId=100,ContactName="Alisha C.",City="Mumbai" },
                new Customer(){ CustomerId=101,ContactName="Manisha K.",City="Mumbai" },
                new Customer(){ CustomerId=102,ContactName="Pravinkumar R. D.",City="Pune" },
                new Customer(){ CustomerId=103,ContactName="Manish Kaushik",City="Bangalore" },
            };
        }
    }
}



/*
 static void Main(string[] args)
        {
            List<int> numbers=new List<int>();
            numbers.Add(100);
            int firstNumber = numbers[0];
        }
 */