using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CreateXMLFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var CustomerOrdersDocument = new XElement("Customers", new XElement
                ("Customer", new XAttribute("CustomerId", 1001), new XAttribute
                ("ContactName", "Alisha C."), new XAttribute("City", "Mumbai"), 
                new XElement("Orders", new XElement("Order", new XAttribute("OrderId", "100")))));


            var abhishek = new XElement("India", new XElement("State", new XAttribute("Rajasthan", "RJ13"), new XElement("City", "Sri Ganganagar")));

            var html = new XElement("html", new XElement("head", new XElement("title","Abhishek's Code")),
                new XElement("body",new XElement("p","paragraph"),new XElement("h1","heading")));
            Console.WriteLine();
            Console.WriteLine(CustomerOrdersDocument);
            Console.WriteLine();
            Console.WriteLine(abhishek);
            Console.WriteLine();
            Console.WriteLine(html);
            Console.ReadKey();
        }
    }
}
