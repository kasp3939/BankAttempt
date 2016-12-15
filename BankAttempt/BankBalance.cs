using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAttempt
{
    class BankBalance
    {
        public double Deposit { get; set; }

        public double WithDraw { get; set; }

        public double Balance { get; set; }

        public BankBalance(double deposit, double withDraw, double balance)
        {
            deposit = Deposit;
            withDraw = WithDraw;
            balance = Balance;
        }

        public BankBalance()
        {

        }
    }
}
