using System;

namespace FirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Infoway! CDAC!");
            Console.WriteLine("Please enter your name - ");
            try
            {
                string name = Console.ReadLine();
                Console.WriteLine("Please enter your age - ");
                int age = int.Parse(Console.ReadLine());
                if (age < 80)
                {
                    Console.WriteLine($"{name}! Your ride is ready! Enjoy!");
                }
                else
                {
                    Console.WriteLine($"{name}! Sorry you can not do this activity!");
                }
                Console.WriteLine($"{name}! Sorry you can not do this activity!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

            Console.ReadKey();
        }
    }
}
