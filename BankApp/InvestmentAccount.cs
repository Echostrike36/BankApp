using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class InvestmentAccount : Account
    {
        public double InterestRate { get; set; } = 0.10;
        public static double WithdrawlPenalty { get; private set; } = 0.18;
        public static double WithdrawlLimit { get; set; } = 6;
        public double MonthlyNumberOfWithdrawls { get; private set; }

        public InvestmentAccount(Guid customerId)
        {
            // Simulate loading from database
            Balance = 5000.00;
            MonthlyNumberOfWithdrawls = 4;
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
