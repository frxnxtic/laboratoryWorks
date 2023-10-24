using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZVP.Laba1
{
    internal interface IBankAccount
    {
        string accountNumber { get; set; }
        decimal balance { get; set; }

        void Deposit(decimal amount);
        void Withdraw(decimal amount);
    }
}
