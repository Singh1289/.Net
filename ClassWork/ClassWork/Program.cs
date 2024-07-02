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
            var allCustomer = from  customer in list 
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


            Console.WriteLine("Count Customers form each Cities by dictionary : ");

            // with Dictionary 
            Dictionary<String,int> map = new Dictionary<String,int>();
            foreach (Customers c in list) 
            {
                if (map.ContainsKey(c.city))
                { 
                    map[c.city]++;        // arr[4] =6
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

            Console.WriteLine("\n Without Dictionary counting customers");
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


            Console.WriteLine("basic method : ");
            int pune, mumbai, delhi, kota;
            pune=mumbai=delhi=kota=0;
            foreach (Customers cc in list)
            {
                if (cc.city == "Pune")
                 pune++; 
               if (cc.city == "Mumbai")
                 mumbai++; 
                if (cc.city == "Delhi")
                 delhi++; 
              if (cc.city == "Kota")
                 kota++;

            }
            Console.WriteLine($"Pune : {pune}");
            Console.WriteLine($"mumbai : {mumbai}");
            Console.WriteLine($"delhi : {delhi}");
            Console.WriteLine($"kota : {kota}");
            Console.WriteLine("\nCustomer by id search :\n");

            //var acc = from customer in list where customer.CustomerId == 2 select customer;

          // var acc = from customer in list orderby customer.city descending, customer.CustomerName  select customer;




       //      foreach (Customers it in acc)
            {
                Console.WriteLine($"Customer : {it.CustomerId} - {it.CustomerName} - {it.city}");
            }



            var sm = from cust in list group cust by cust.CustomerId select customer;

            foreach (Customers it in sm)
            {
                Console.WriteLine($"Count: {it.CustomerId} - {it.CustomerName} - {it.city}");
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
