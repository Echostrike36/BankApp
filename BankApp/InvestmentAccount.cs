using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class InvestmentAccount : InterestBearingAccount
    {
        public static double WithdrawlLimit { get; private set; }
        public static double WithdrawlPenalty { get; private set; }
        public double MonthlyNumberOfWithdrawls { get; private set; }

        public InvestmentAccount(Guid customerId, IInvestmentAccountOptions accountOptions)
        {
            // Simulate loading from database
            AccountNumber = new Guid();
            Balance = 5000.00;
            MonthlyNumberOfWithdrawls = 4;
            InterestRate = accountOptions.InterestRate;
            WithdrawlLimit = accountOptions.WithdrawlLimit;
            WithdrawlPenalty = accountOptions.WithdrawlPenalty;
        }

        public override void Withdrawl(double amount)
        {
            if (MonthlyNumberOfWithdrawls < WithdrawlLimit)
            {
                Balance -= amount + (amount * WithdrawlPenalty);
            }
            else
            {
                throw new Exception("User is at or over the Montly Withdrawl limit.");
            }
        }

        public override void Deposit(double amount)
        {
            Balance += amount;
        }

        public void AddOneMonthInterest()
        {
            Balance = Balance + (Balance * InterestRate);
        }
    }
}
