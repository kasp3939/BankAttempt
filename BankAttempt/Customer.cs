using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAttempt
{
    internal class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BankNumber { get; set; }

         public Dictionary<string, Customer> listOfCustomers { get; set; }

        public Customer(string firstName, string lastName, int bankNumber)
        {
            firstName = FirstName;
            lastName = LastName;
            bankNumber = BankNumber;

        }
        public Customer()
        {
            
        }

          

    }
}
