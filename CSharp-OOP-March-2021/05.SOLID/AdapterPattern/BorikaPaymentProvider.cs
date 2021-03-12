using AdapterPattern.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    class BorikaPaymentProvider : IBorikaPayment
    {
        public decimal CheckMoneyLeft(int id)
        {
            // finds by id
            // asks borika about this
            return 42;
        }

        public bool PayMoney(decimal amount)
        {
            // pays to borika
            return true;
        }
    }
}
