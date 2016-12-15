using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Threading.Tasks;

namespace BankAttempt
{
    class Program
    {

        string firstName = "";
        string lastName = "";
        string bankNumber = "";
        Customer customer = new Customer();

        private bool isRunning;

        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
        }

        private void Run()
        {
            bool running = true;
            try
            {
                do
                {
                    int input = Menu();
                    switch (input)
                    {
                        case 1: CreateCustomer(); break;
                        case 2: DepositAmount(); break;
                        case 3: WithDrawAmount(); break;
                        case 4: UpdateAccount(); break;
                        case 5: ViewAccounts(); break;
                        case 10: running = false; break;
                    }
                    Console.Clear();
                } while (running);
            }
            catch 
            {
                Console.WriteLine("UPS ");
                Console.ReadKey();
            }
        }
          private void CreateCustomer()
        {
            throw new NotImplementedException();
        }
        private void ViewAccounts()
        {
            throw new NotImplementedException();
        }

        private void UpdateAccount()
        {
            throw new NotImplementedException();
        }

      
        private void DepositAmount()
        {
            throw new NotImplementedException();
        }

        private void WithDrawAmount()
        {
            throw new NotImplementedException();
        }

       
     
        private int Menu()
        {
            Console.WriteLine("Welcome to the Fed. Bank!");
            Console.WriteLine("=========================");
            Console.WriteLine();
            Console.WriteLine("Please choose your command");
            Console.WriteLine("1) Create new account");
            Console.WriteLine("2) Deposit an amount");
            Console.WriteLine("3) Withdraw an amount");
            Console.WriteLine("4) Update your account");
            Console.WriteLine("5) View Accounts");

            string input = Console.ReadLine();
            Console.Clear();
            int inputNum = Convert.ToInt32(input);
            return inputNum;
        }        

        public void ChooseACommand()
        {

        }

        public bool CheckFirstName(string firstName)
        {
            List<char> letters = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'æ', 'ø', 'å' };
            bool IsOnlyLetters = false;
            foreach (char character in firstName)
            {
                if (letters.Contains(character))
                {
                    IsOnlyLetters = true;
                }
                else
                {
                    IsOnlyLetters = false;
                }
            }
            return IsOnlyLetters;
        }

        public bool CheckLastName(string lastName)
        {
            List<char> letters = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'æ', 'ø', 'å' };
            bool IsOnlyLetters = false;
            foreach (char character in lastName)
            {
                if (letters.Contains(character))
                {
                    IsOnlyLetters = true;
                }
                else
                {
                    IsOnlyLetters = false;
                }
            }
            return IsOnlyLetters;
        }
    }
}
