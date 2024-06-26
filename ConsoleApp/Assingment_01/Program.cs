using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                Student stu = new Student(01,"Abhishek",96);
                stu.onSelection += new basket(mongodb);
                stu.onRejection += new basket(mysqldb);
                stu.onTop += new basket(topper);
                

                if (stu.marks<90)
                {
                    stu.onTop -= new basket(topper);
                }

                Console.WriteLine(stu.calculateResult());
                Console.ReadLine();

			}
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
                throw;
			}
        }
        private static void mongodb() 
        {
            Console.WriteLine("Data stored in mongoDB");
        }

        private static void mysqldb()
        {
            Console.WriteLine("Data stored in mysqlDB");
        }

        private static void topper()
        {
            Console.WriteLine($" topped the class.");
        }

    }
}
