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
            Console.WriteLine(CustomerOrdersDocument);
            Console.ReadKey();
        }
    }
}
