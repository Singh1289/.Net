using ClassWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // Basic Select * from Customers
            var allCustomer = from Customer in GetAllCustomer()
                              select Customer;
            foreach (var item in allCustomer)
            {
                Console.WriteLine($"{item.CustomerId} - {item.CustomerName} - {item.city}");
            }
            
            //where  clause
            var allCustomer = from  Customer in GetAllCustomer()
                                  //where Customer.city == "Pune"
                              where Customer.city.Contains("D")
                              select Customer;
            
            // order by
            var allCustomer = from cust in GetAllCustomer()    
                              orderby cust.city,cust.CustomerName descending
                              select cust;
            
            foreach (var item in allCustomer)
            {
                Console.WriteLine($"{item.CustomerId} - {item.CustomerName} - {item.city}");
            }
            
            // joijn two table
            var customerJoin = from cust in GetAllCustomer()
                               join v_order in GetAllOrder() on
                               cust.CustomerId equals v_order.CustomerId
                               select new { 
                                            CustomerId = cust.CustomerId,
                                            OrderId = v_order.OrderId,
                                            Name= cust.CustomerName,
                                            City= cust.city,
                                            Date= v_order.OrderDate,
                                            quantity= v_order.Quantity,
                                           };


            foreach (var item in customerJoin)
            {
                Console.WriteLine($"{item.CustomerId} - {item.OrderId} - {item.Name} - {item.City} - {item.Date} - {item.quantity}");
            }
            
            // two table join
            var customerJoin = from cust in GetAllCustomer()
                               join v_order in GetAllOrder() on
                               cust.CustomerId equals v_order.CustomerId

                               join v_product in GetAllProducts() on
                               v_order.ProductId equals v_product.ProductId

                               select new
                               {
                                   CustomerId = cust.CustomerId,
                                   OrderId = v_order.OrderId,
                                   Name = cust.CustomerName,
                                   City = cust.city,
                                   Date = v_order.OrderDate,
                                   quantity = v_order.Quantity,
                                   productName= v_product.ProductName,
                                   total = v_product.UnitPrice * v_order.Quantity,
                                   unitPrice= v_product.UnitPrice
                               };


            foreach (var item in customerJoin)
            {
                Console.WriteLine($"{item.CustomerId} - {item.OrderId} - {item.Name} - " +
                                   $"{item.City} - {item.Date} - {item.productName} - " +
                                   $"{item.quantity} - {item.unitPrice} - {item.total}");
            }
            */

            var customerJoin = from cust in GetAllCustomer()
                               join v_order in GetAllOrder() on
                               cust.CustomerId equals v_order.CustomerId

                               join v_product in GetAllProducts() on
                               v_order.ProductId equals v_product.ProductId

                               join v_emp in GetAllEmployee() on 
                               v_order.EmpID equals v_emp.EmpId

                               select new
                               {
                                   Empid = v_emp.EmpId,
                                   EmpName = v_emp.EmpName,
                                   CustomerId = cust.CustomerId,
                                   OrderId = v_order.OrderId,
                                   Name = cust.CustomerName,
                                   City = cust.city,
                                   Date = v_order.OrderDate,
                                   quantity = v_order.Quantity,
                                   productName = v_product.ProductName,
                                   total = v_product.UnitPrice * v_order.Quantity,
                                   unitPrice = v_product.UnitPrice
                               };


            foreach (var item in customerJoin)
            {
                Console.WriteLine($"{item.CustomerId} - {item.OrderId} - {item.Name} - " +
                                   $"{item.City} - {item.Date} - {item.productName} - " +
                                   $"{item.quantity} - {item.unitPrice} - {item.total} - {item.EmpName} - {item.Empid}");
            }



            Console.ReadKey();  
        }

        public static List<Customers> GetAllCustomer()
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

        public static List<Order> GetAllOrder()
        {
            return new List<Order>() 
            {
                new Order(){OrderId=101,CustomerId=2,OrderDate=DateTime.Now,Quantity=10,ProductId=1000,EmpID=11},
                new Order(){OrderId=102,CustomerId=4,OrderDate=DateTime.Now,Quantity=15,ProductId=1001,EmpID=12},
                new Order(){OrderId=103,CustomerId=3,OrderDate=DateTime.Now,Quantity=20,ProductId=1002, EmpID = 12},
                new Order(){OrderId=104,CustomerId=1,OrderDate=DateTime.Now,Quantity=11, ProductId = 1000, EmpID = 11},
                new Order(){OrderId=105,CustomerId=6,OrderDate=DateTime.Now,Quantity=5,ProductId=1002, EmpID = 13},
                new Order(){OrderId=106,CustomerId=6,OrderDate=DateTime.Now,Quantity=6, ProductId = 1002, EmpID = 13},
                new Order(){OrderId=107,CustomerId=1,OrderDate=DateTime.Now,Quantity=2,ProductId=1001, EmpID = 11},
                new Order(){OrderId=108,CustomerId=1,OrderDate=DateTime.Now,Quantity=4, ProductId = 1000, EmpID = 14}
            };
        }

        private static List<Product> GetAllProducts()
        {
            var products = from product in XElement.Load(@"D:\Infoway\.Net\ClassWork\LinqExample\Product.xml").Elements()
                           select new Product
                           {
                               ProductId = int.Parse(product.Attribute("ProductId").Value),
                               ProductName = product.Attribute("ProductName").Value,
                               UnitPrice = decimal.Parse(product.Attribute("UnitPrice").Value),
                           };
            return products.ToList();
        }

        public static List<Employee> GetAllEmployee()
        {
            return new List<Employee>()
            {
                new Employee() { EmpId=11, EmpName= "Jack" },
                new Employee() { EmpId=12, EmpName= "Reacher" },
                new Employee() { EmpId=13, EmpName= "John Wick" },
                new Employee() { EmpId=14, EmpName= "Agent 47" }
            };
        }
    }
}
