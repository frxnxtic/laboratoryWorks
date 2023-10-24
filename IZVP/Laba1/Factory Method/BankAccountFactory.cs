using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZVP.Laba1
{
    internal class BankAccountFactory : IBankAccountFactory
    {
        public IBankAccount CreateBankAccount(string accountType)
        {
            return accountType switch
            {
                "Savings" => new SavingsAccount(),
                "Checking" => new CheckingAccount(),
                "MoneyMarket" => new MoneyMarketAccount(),
                _ => throw new ArgumentException("Invalid account type", "accountType"),
            };
        }
    }
}
