using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSeggregation
{
    internal interface IPayable
    {
        void Pay();
    }


    interface IAvailabilityChecker
    {
        bool CheckAvailability();
    }
}
