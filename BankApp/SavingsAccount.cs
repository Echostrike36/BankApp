using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class SavingsAccount : Account
    {
        public static double InterestRate { get; set; } = 0.01;

        public SavingsAccount(Guid customerId)
        {
            // Simulate loading from database
            Balance = 500.00;
        }

        public void AddOneMonthInterest()
        {
            Balance = Balance + (Balance * InterestRate);
        }
    }
}
