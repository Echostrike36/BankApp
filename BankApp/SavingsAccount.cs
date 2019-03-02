using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class SavingsAccount : InterestBearingAccount
    {
        public override double InterestRate { get; private protected set; } = 0.01;

        public SavingsAccount(Guid customerId, IInterestBearingAccountOptions accountOptions)
        {
            // Simulate loading from database
            AccountNumber = new Guid();
            Balance = 500.00;
            InterestRate = accountOptions.InterestRate;
        }

        public void AddOneMonthInterest()
        {
            Balance = Balance + (Balance * InterestRate);
        }
    }
}
