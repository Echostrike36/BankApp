using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    abstract class InterestBearingAccount : BaseAccount
    {
        public virtual double InterestRate { get; private protected set; }
    }
}
