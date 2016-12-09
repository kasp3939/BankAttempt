using ClassTest1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassTest1;

using System.Threading.Tasks;

namespace BankAttempt
{
    class Program
    {
        string firstName = "";
        string lastName = "";
        string phone = "";
        
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
        }

        private void Run()
        {
            Console.WriteLine("Welcome to the Fed. Bank!");
            Console.WriteLine("=========================");
            Console.ReadKey();

        } 

        private void _createAccount()
        {
            string FirstName = "";
            Console.WriteLine("Please type in your first name: ");
            
            
        }
    }
}
