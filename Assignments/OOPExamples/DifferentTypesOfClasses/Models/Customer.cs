using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentTypesOfClasses.Models
{
     class Customer:Person
    {
        public Customer() 
        {
            Console.WriteLine("Customer class constrcutor executed!");
        }
        public int CustomerId { get; set; }

        public override string ChangeAddress(string oldAddress, string newAddress)
        {
            return string.Format($"Customer {ContactName} has changed his/her address from {oldAddress} to {newAddress}!");
        }
    }
}
