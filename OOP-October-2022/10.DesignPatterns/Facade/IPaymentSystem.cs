using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{

    //Facade
    internal interface IPaymentSystem
    {
        bool MakePayment(Account from, Account to);
    }
}
