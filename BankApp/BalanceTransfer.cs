using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class BalanceTransfer
    {
        public void TransferBalance(Account withdralAccount, Account depositAccount, int amount)
        {
            withdralAccount.Withdrawl(amount);
            depositAccount.Deposit(amount);
        }
    }
}
