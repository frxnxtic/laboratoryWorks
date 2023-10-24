using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZVP.Laba1
{
    internal interface IBankAccountFactory
    {
        IBankAccount CreateBankAccount(string accountType);
    }
}
