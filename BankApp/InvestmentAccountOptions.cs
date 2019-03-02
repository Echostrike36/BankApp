using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class InvestmentAccountOptions : IAccountOptions
    {
        public double InterestRate { get; private set; }
        public InvestmentAccountOptions()
        {}
        public InvestmentAccountOptions(double interestRate)
        {
            InterestRate = interestRate;
        }
    }
}
