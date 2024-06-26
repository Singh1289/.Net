using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConstructorExamples
{
    internal class Child:Parent
    {
        public Child() : base(100,"ABCD")
        {
            Console.WriteLine("Default Constructor Of Child Class!");
        }
        public Child(int id, string name):this()
        {
            Console.WriteLine("Parameterized Constructor Of Child Class!");
            Id = id * 100;
            Name = name;
        }
    }
}
