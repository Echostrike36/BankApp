using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class CheckingAccount : BaseAccount
    {
        public CheckingAccount(Guid customerId)
        {
            // Simulate pulling from database
            AccountNumber = new Guid();
            Balance = 50.00;
        }
    }
}
