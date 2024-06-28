using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ticketNumbers = new ArrayList();
            ticketNumbers.Add(1000);
            ticketNumbers.Add(1001);
            ticketNumbers.Add(1002);
            int firstTicket = Convert.ToInt32(ticketNumbers[0]);
            foreach (var item in ticketNumbers)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
