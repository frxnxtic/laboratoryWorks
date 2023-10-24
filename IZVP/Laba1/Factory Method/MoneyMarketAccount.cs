using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZVP.Laba1
{
    internal class MoneyMarketAccount : IBankAccount
    {
        public string accountNumber { get; set; }
        public decimal balance { get; set; }
        public decimal minimumBalance { get; set; }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (balance - amount < minimumBalance)
            {
                throw new Exception("Insufficient funds.");
            }

            balance -= amount;
        }
    }
}
