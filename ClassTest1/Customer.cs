using System;
using ClassTest1;

namespace ClassTest1
{
    internal class Customer
    {
      

        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public string BankNumber { get; internal set; }
        public object ID { get; internal set; }

        public Customer()
        {

        }

        public Customer(string firstName, string lastName, string bankNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            BankNumber = bankNumber; 
        }
   
    }
}