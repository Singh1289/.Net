using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACSII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Enter Any Character " );
            //char c = Console.ReadKey().KeyChar;
            char c = Console.ReadLine()[0];
            int ascii = c;

            Console.WriteLine( $"The ASCII value of {c} is {ascii}" );

            Console.ReadKey();

        }
    }
}
