using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Login.Models;
using System.Threading.Tasks;

namespace Login.Dal
{
    internal interface IEmployeeDal
    {
         Employee checkCredential();

        void addEmployee(Employee employee);
    }

   
}
