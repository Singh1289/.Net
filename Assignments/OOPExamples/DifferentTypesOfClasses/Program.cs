using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DifferentTypesOfClasses.Models;
using MH=India.Maharashtra;
using UP=India.UttarPradesh;

namespace DifferentTypesOfClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasicMath basicMath=new BasicMath();
            var CustomerOrderClass = new { CustomerId=2300, ContactName="Alisha C.",City="Mumbai", OrderId=23892,OrderDate=DateTime.Now };
            /*PrimeCustomer customer=new PrimeCustomer();
            customer.CustomerId = 100;
            customer.ContactName= "Test";
            customer.Address = "MoonCity";
            customer.City = "Pune";
            customer.Fees = 1200;
            Console.WriteLine( customer.ChangeAddress(customer.Address, "Suncity"));*/
            Console.ReadKey();
        }
    }
}


namespace India
{
    namespace Maharashtra
    {
        class Pune
        {

        }
    }
    namespace UttarPradesh
    {
        class Pune
        {

        }
    }
}