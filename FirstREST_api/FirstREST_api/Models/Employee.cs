using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstREST_api.Models
{
    public class Employee
    {
        private int EmployeeId {  get; set; }
        public String EmployeeName { get; set; }
        public String Address { get; set; }
        public String City { get; set; }
        public int  Phone { get; set; }
    }
}