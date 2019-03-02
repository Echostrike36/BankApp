using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class BalanceTransfer
    {
        public void TransferBalance(BaseAccount withdralAccount, BaseAccount depositAccount, int amount)
        {
            withdralAccount.Withdrawl(amount);
            depositAccount.Deposit(amount);
        }
    }
}
