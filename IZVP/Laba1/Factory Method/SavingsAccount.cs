using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZVP.Laba1
{
    internal class SavingsAccount : IBankAccount
    {
        public string accountNumber { get; set; }
        public decimal balance { get; set; }
        public decimal interestRate { get; set; }
        public void Deposit(decimal amount)
        {
            balance += amount;
            EarnInterest();
        }

        private void EarnInterest()
        {
            balance += balance * interestRate / 100;
        }

        public void Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
            }
            else
            {
                throw new Exception("Insufficient funds");
            }
        }
    }
}
