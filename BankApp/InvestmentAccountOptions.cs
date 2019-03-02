using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class InvestmentAccountOptions : IInvestmentAccountOptions
    {
        public double InterestRate { get; private set; } = 0.10;
        public int WithdrawlLimit { get; private set; } = 6;
        public double WithdrawlPenalty { get; private set; } = 0.18;

        public InvestmentAccountOptions()
        {}
    }
}
