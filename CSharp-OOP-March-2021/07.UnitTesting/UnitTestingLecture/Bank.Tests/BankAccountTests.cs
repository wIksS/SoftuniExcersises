using NUnit.Framework;
using System;

namespace Bank.Tests
{
    [TestFixture]
    public class BankAccountTests
    {
        private decimal amount;
        private string name;
        private BankAccount bankAccount;

        [SetUp]
        public void SetUp()
        {
            this.name = "Pesho";
            this.amount = 5;
            this.bankAccount = new BankAccount(this.amount, this.name);
        }

        [Test]
        public void When_AccountInitalizedWithPositiveValue_Amount_ShouldBeChanged()
        {
            Assert.That(bankAccount.Amount, Is.EqualTo(amount));          
        }

        [Test]
        public void When_AccountDepositIsMade_ShouldChangeAmount()
        {
            bankAccount.Deposit(amount);

            Assert.That(bankAccount.Amount, Is.EqualTo(amount * 2));
        }
    }
}
