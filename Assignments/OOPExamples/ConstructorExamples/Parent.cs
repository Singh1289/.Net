using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExamples
{
    internal class Parent
    {
        static Parent()
        {
            Console.WriteLine("Static Constructor Of Parent Class!");
        }
        public Parent()
        {
            Console.WriteLine("Default Constructor Of Parent Class!");
        }
        public Parent(int id,string name):this()
        {
            Console.WriteLine("Parameterized Constructor Of Parent Class!");
            Id= id*100;
            Name= name; 
        }
        public Parent(Parent p)
        {
            Id= p.Id;
            Name= p.Name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
