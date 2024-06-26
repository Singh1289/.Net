using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lINKEDlISTaRRAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<String> my_list = new LinkedList<String>();

            
            my_list.AddFirst("ABC");
            my_list.AddLast("DEF");
            my_list.AddLast("HIJ");
            my_list.AddLast("KLM");
            my_list.AddLast("NOP");
     


            

            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }

            
            Console.ReadKey();
        }

    }
}
