using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable employees= new Hashtable();
            employees.Add(1000, "A");
            employees.Add(1001, "B");
            employees.Add(1002, "C");
            employees.Add(1003, "D");
            foreach (var key in employees.Keys)
            {
                Console.WriteLine($"Employee Id - {key} with the name {employees[key]}!");
            }
        }
    }
}
