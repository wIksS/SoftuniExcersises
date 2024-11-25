using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.Promotions
{
    public interface IPromotion
    {
        decimal GetPrice(decimal price);
    }
}
