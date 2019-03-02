using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    interface IInvestmentAccountOptions : IInterestBearingAccountOptions
    {
        int WithdrawlLimit { get; }
        double WithdrawlPenalty { get; }
    }
}
