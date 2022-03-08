using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {
        private readonly string EGN;
        private Account account;
        private int angryLevel;

        public Person(string EGN, Account bankAccount)
        {
            this.EGN = EGN;
            account = bankAccount;
        }

        public void SendMoney(Account toAccount, int amount)
        {
            // send EGN
            account.Amount -= amount;
            toAccount.Amount += amount;
        }

        public void PayTax()
        {
            angryLevel += 100;
            ChekcAngryLevel();
        }

        private void ChekcAngryLevel()
        {
            if (angryLevel > 1000)
            {
                // stop working
            }
        }
    }
}
