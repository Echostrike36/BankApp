using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class SavingsAccountOptions : IAccountOptions
    {
        public double InterestRate { get; private set; } = 0.01;

        public SavingsAccountOptions(double interestRate)
        {
            InterestRate = InterestRate;
        }
        public SavingsAccountOptions()
        {}
    }
}
