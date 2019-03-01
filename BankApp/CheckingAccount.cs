using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class CheckingAccount : Account
    {
        public CheckingAccount(Guid customerId)
        {
            // Simulate pulling from database
            Balance = 50.00;
        }
    }
}
