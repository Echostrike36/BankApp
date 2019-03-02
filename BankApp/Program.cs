using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Guid customer1 = new Guid();
            IInterestBearingAccountOptions savingsAccountOptions = new SavingsAccountOptions();
            IInvestmentAccountOptions investmentAccountOptions = new InvestmentAccountOptions();

            SavingsAccount savings = new SavingsAccount(customer1, savingsAccountOptions);
            InvestmentAccount investment = new InvestmentAccount(customer1, investmentAccountOptions);
            CheckingAccount checking = new CheckingAccount(customer1);
            Console.WriteLine($"Savings Balance == {savings.Balance}");
            Console.WriteLine($"Checking Balance == {checking.Balance}");
            Console.WriteLine($"Investment Balance == {investment.Balance}");

            Console.WriteLine("Transfer $10 from checking to savings.");
            BalanceTransfer transfer = new BalanceTransfer();
            transfer.TransferBalance(savings, checking, 10);

            Console.WriteLine($"Savings Balance == {savings.Balance}");
            Console.WriteLine($"Checking Balance == {checking.Balance}");

            Console.ReadKey();
        }
    }
}
