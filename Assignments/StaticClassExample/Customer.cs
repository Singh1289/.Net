using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassExample
{
    internal static class Customer
    {
        public static string CustomerName { get; set; } = "Sarvesh";
        public static string CustomerPhone { get; set; } = "943465723";
        public static string CustomerCity { get; set; } = "Pune";


        public static string GetCountry()
        { 
            return "India";
        }
    }
}
