using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customers> list = GetAllCustomer();
            Console.WriteLine( "counting customers by linq :-" );
            var allCustomer = from Customers customer in list 
                              group customer by customer.city into Cities
                              select new { 
                                City=Cities.Key,Count= Cities.Count()
                              };

            foreach (var item in allCustomer)
            {
                Console.WriteLine($"{item.City} - {item.Count}");
            }

            Console.WriteLine();
            //foreach (var c in allCustomer)
            //{
            //    Console.WriteLine($"{c.CustomerId} - {c.CustomerName} - {c.city}");
            //}


            Console.WriteLine("Count Customers form each Cities: ");

            // with Dictionary 
            Dictionary<String,int> map = new Dictionary<String,int>();
            foreach (Customers c in list) 
            {
                if (map.ContainsKey(c.city))
                { 
                    map[c.city]++;
                } 
                else 
                {
                    map.Add(c.city, 1); 
                }
            }

            foreach (var str in map)
            {
                Console.WriteLine($"{str.Key} - {str.Value}");
            }

            // without Dictionary

            Console.WriteLine("\nWithout Dictionary counting customers");
            List<UserMap> userMaps = new List<UserMap>();

            foreach (Customers cc in list)
            {
                UserMap uu = userMaps.Find(delegate (UserMap u1) { return u1.city == cc.city; });
                if (uu != null)
                {
                    uu.count++;
                }
                else
                {
                    userMaps.Add(new UserMap() { city = cc.city, count = 1 });
                }
            }

            foreach (UserMap temp in userMaps)
            {
                Console.WriteLine($"{temp.city} - {temp.count}");
            }



            Console.ReadKey();
        }

        private static List<Customers> GetAllCustomer() 
        {
            return new List<Customers>()
            {
                new Customers() {CustomerId=1,CustomerName="Amit",city="Pune" },
                new Customers() {CustomerId=2, CustomerName = "Sunil", city = "Pune" },
                new Customers() {CustomerId=3, CustomerName = "Ajay", city = "Mumbai" },
                new Customers() {CustomerId=4, CustomerName = "Rohit", city = "Delhi" },
                new Customers() {CustomerId=5, CustomerName = "Mukul", city = "Mumbai" },
                new Customers() {CustomerId=6, CustomerName = "piyush", city = "Pune" },
                new Customers() {CustomerId=7, CustomerName = "Harsh", city = "Kota" }
            };
        }
    }
}
