using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Contract
{
    interface IBorikaPayment
    {
        bool PayMoney(decimal amount);

        decimal CheckMoneyLeft(int id);
    }
}
