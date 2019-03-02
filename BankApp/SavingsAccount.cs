﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class SavingsAccount : BaseAccount
    {
        public static double InterestRate { get; set; } = 0.01;

        public SavingsAccount(Guid customerId)
        {
            // Simulate loading from database
            AccountNumber = new Guid();
            Balance = 500.00;
        }

        public void AddOneMonthInterest()
        {
            Balance = Balance + (Balance * InterestRate);
        }
    }
}
