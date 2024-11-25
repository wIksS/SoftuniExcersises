using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.Promotions
{
    public class ChristmasPromotion : IPromotion
    {
        public decimal GetPrice(decimal price)
        {
            if (DateTime.Now.Date.Month == 12 && DateTime.Now.Date.Day == 25)
            {
                price *= 0.6m;
            }

            return price;
        }
    }
}
