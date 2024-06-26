using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentTypesOfClasses.Models
{
    sealed class PrimeCustomer:Customer
    {
        public PrimeCustomer() 
        {
            Console.WriteLine("Prime Customer class constrcutor executed!");
        }
        public decimal Fees { get; set; } = 1400;
    }
}
