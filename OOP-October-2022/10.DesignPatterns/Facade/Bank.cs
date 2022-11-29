using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    internal class Bank
    {
        public void MakePayment(Account from, Account to, decimal amount)
        {
            from.Transfer(to, amount);
        }
    }
}
