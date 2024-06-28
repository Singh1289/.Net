using System;
using System.IO;

namespace FIleClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Infoway\.Net\Logger.txt";
            if (!File.Exists(path))
            {
                var fs = File.Create(path);
                fs.Close();
                fs.Dispose();
            }
            //File.WriteAllText(path, "Welcome To Infoway!");
            // File.AppendAllText(path, "\nWelcome To India !");
             //File.AppendAllText(path, "\nWelcome To Rajasthan !");

            using (StreamReader sr = new StreamReader(path))
            {
                //Console.WriteLine(sr.ReadToEnd());
                while (sr.Peek()!= -1)
                {
                    //Console.WriteLine(sr.ReadLine());
                    Console.WriteLine(Convert.ToChar(sr.Read()));
                }
            }

            Console.ReadKey();
        }
    }
}
