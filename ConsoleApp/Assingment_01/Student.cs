using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_01
{
    public delegate void basket();
    internal class Student
    {
        public event basket onSelection;
        public event basket onRejection;
        public event basket onTop;
        public int Id { get; set; }
        public string Name { get; set; }
        public int marks { get; set; }

        public Student()
        {
                
        }

        public Student(int id,string n, int m )
        {
            this.Id = id;
            this.Name = n;
            this.marks = m;
        }

        public String calculateResult()
        {
            if (marks > 80)
            {
                if (onSelection != null)
                {
                    onSelection();
                }
                if (onTop != null)
                {
                    onTop();
                }
                return System.String.Format($"{Name} is passed. ");
            }
            else
            {
                if (onRejection != null)
                {
                    onRejection();
                }
                return System.String.Format($"{Name} is rejected. ");
            }
        }

        public void Cites(params string[] str)
        {
            foreach (string str2 in str)
            {
                Console.WriteLine(str2);
            }

        }
    }
}