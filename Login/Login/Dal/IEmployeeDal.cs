using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FirstREST_api.Models;
using System.Threading.Tasks;

namespace FirstREST_api.Dal
{
    internal interface IEmployeeDal
    {
         Employee checkCredential();

        void addEmployee(Employee employee);
    }

   
}
