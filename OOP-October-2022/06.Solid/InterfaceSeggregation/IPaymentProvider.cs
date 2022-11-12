using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSeggregation
{
    internal interface IPaymentProvider
    {
        void Pay();

        void Check3ds();

        void CheckAvailability();


    }
}
