using System;

namespace MenuDriven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, opt;

            Console.WriteLine("A menu-driven program for a simple calculator:");
            Console.WriteLine("------------------------------------------------");

            Console.Write("Enter the first Integer: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second Integer: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Here are the options:");
            Console.WriteLine("1-Addition");
            Console.WriteLine("2-Subtraction");
            Console.WriteLine("3-Multiplication");
            Console.WriteLine("4-Division");
            Console.WriteLine("5-Exit");
            Console.Write("Input your choice: ");
            opt = Convert.ToInt32(Console.ReadLine());
            try
            {
                switch (opt)
                {
                    case 1:
                        Console.WriteLine($"The Addition of {num1} and {num2} is: {num1 + num2}");
                        break;
                    case 2:
                        Console.WriteLine($"The Subtraction of {num1} and {num2} is: {num1 - num2}");
                        break;
                    case 3:
                        Console.WriteLine($"The Multiplication of {num1} and {num2} is: {num1 * num2}");
                        break;
                    case 4:
                        if (num2 == 0)
                        {
                            Console.WriteLine("The second integer is zero. Division not possible.");
                        }
                        else
                        {
                            Console.WriteLine($"The Division of {num1} by {num2} is: {num1 / (double)num2}");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Thank you");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}