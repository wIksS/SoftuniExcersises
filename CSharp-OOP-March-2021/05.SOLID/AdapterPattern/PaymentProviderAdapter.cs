using AdapterPattern.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    class PaymentProviderAdapter : IPaymentProvider
    {
        private BorikaPaymentProvider provider;
        public PaymentProviderAdapter(BorikaPaymentProvider provider)
        {
            this.provider = provider;
        }

        public bool CheckAvailableMoney(string accountName)
        {
            provider.CheckMoneyLeft(42);

            return true;
        }

        public bool PayAmount(decimal amount)
        {
            return provider.PayMoney(amount);
        }
    }
}
