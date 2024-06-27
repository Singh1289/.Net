using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData_12
{
    internal class Employee
    {
        public int EmployeeId { get; set; }
        public int DepartmentNo { get; set; }
        public String DepartmentName { get; set; }
        public char DesignationCode { get; set; }
        public String Designation { get; set; }

        public Employee()
        {              
        }

        public Employee(int id, int departNo,String deName, char deCode, String Design)
        {
            EmployeeId = id;
            DepartmentNo = departNo;
            DepartmentName = deName;
            DesignationCode = deCode;
            Designation = Design;
        }

        public void display() 
        {
            Console.WriteLine($"       {DepartmentNo}          {DepartmentName}                {DesignationCode}           {Designation}");
        }
    }
}
