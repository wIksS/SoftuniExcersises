using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Contract
{
    interface IPaymentProvider
    {
        bool PayAmount(decimal amount);

        bool CheckAvailableMoney(string accountName);
    }
}
