﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    abstract class BaseAccount
    {
        public double Balance { get; private protected set; }
        public Guid AccountNumber { get; private protected set; }

        public virtual void Withdrawl(double amount)
        {
            Balance -= amount;
        }

        public virtual void Deposit(double amount)
        {
            Balance += amount;
        }


    }
}
