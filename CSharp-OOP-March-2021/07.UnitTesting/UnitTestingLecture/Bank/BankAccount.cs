using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class BankAccount
    {
        private decimal amount = 0;

        public BankAccount(decimal amount, string name)
        {
            AccountName = name;
            Amount = amount;
        }

        public string AccountName { get; set; }

        public decimal Amount
        {
            get { return amount; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("No negatives");
                }

                amount = value;
            }
        }

        public void Deposit(decimal amount)
        {
            Amount += amount;
        }
    }
}
