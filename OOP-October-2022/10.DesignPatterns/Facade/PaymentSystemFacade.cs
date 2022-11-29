using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    internal class PaymentSystemFacade : IPaymentSystem
    {
        private Bank bank = new Bank();
        private BlackList blacklist = new BlackList();
        private ThreeDSVerification verification = new ThreeDSVerification();
        public bool MakePayment(Account from, Account to)
        {

            if (!blacklist.CheckIfAccountisBlackListed(from) && !blacklist.CheckIfAccountisBlackListed(to))
            {
                if (!verification.VerifyAccount(from) && !verification.VerifyAccount(to))
                {
                    bank.MakePayment(to, from, 20);
                    return true;
                }
            }

            return false;
        }
    }
}
