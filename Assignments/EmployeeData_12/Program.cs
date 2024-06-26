using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many employee you want to add : ");
            int size= int.Parse(Console.ReadLine());
            Employee [] emp= new Employee[size];

            int choice,i=0;
            do
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("1.Add Employee");
                Console.WriteLine("2.Display Employee");
                Console.WriteLine("3.Exit");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~");
                Console.Write("Choose One of them : ");
                
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~");
                switch (choice)
                {
                    case 1:
                        if (i < size)
                        {
                            Console.WriteLine("Enter Employee ID");
                            int id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter DepartmentNo");
                            int Dno = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Department Name");
                            string Dname = Console.ReadLine();
                            Console.WriteLine("Enter Designation Code");
                            char DCode = Console.ReadKey().KeyChar;
                            Console.WriteLine(  );
                            Console.WriteLine("Enter Designation");
                            string Des = Console.ReadLine();
                            emp[i] = new Employee(id, Dno, Dname, DCode, Des);
                            i++;
                        }

                        break;
                    case 2:
                        Console.WriteLine(" DepartmentNo | DepartmentName | DesignationCode | Designation");
                        foreach (Employee e in emp)
                        {
                            e.display();
                        }
                        break;
                    case 3: break;

                   // default: Console.WriteLine("Try again..!!");
                }


            } while (choice != 3);
            Console.WriteLine("~~ Thank you ~~");
        }
    }
}
