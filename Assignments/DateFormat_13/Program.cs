using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateFormat_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any date in dd/mm/yy :");
            Console.WriteLine();
            String s = Console.ReadLine();
            String []str= s.Split('/');
            Console.WriteLine($"Month is : {FindMonth(str[1])}");
            Console.WriteLine($"No. of days in the month : {CountDays(str[1], str[2])}");
            Console.ReadKey();
        }

        private static String FindMonth(string v1)
        {
            int m = int.Parse(v1); 
            switch (m)
            {   
                case 01: return "January";
                case 02: return "Februry";
                case 03: return "March";
                case 04: return "April";
                case 05: return "May";
                case 06: return "June";
                case 07: return "July";
                case 08: return "August";
                case 09: return "September";
                case 010: return "October";
                case 011: return "November";
                case 012: return "December";
                default:
                    break;
            }
            return null;
        }

        private static int CountDays(string v1, string v2)
        {
            int m = int.Parse(v1);
            int n = int.Parse(v2);
            switch (m)
            {
                case 01: return 31;
                case 02: return (n%4 ==0) ? 29:28;
                case 03: return 31;
                case 04: return 30;
                case 05: return 31;
                case 06: return 30;
                case 07: return 31;
                case 08: return 31;
                case 09: return 30;
                case 010: return 31;
                case 011: return 30;
                case 012: return 31;
                default:
                    break;
            }
            return 0;
        }
    }
}
