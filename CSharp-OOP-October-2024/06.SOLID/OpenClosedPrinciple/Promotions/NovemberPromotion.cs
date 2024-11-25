using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.Promotions
{
    public class NovemberPromotion : IPromotion
    {
        public decimal GetPrice(decimal price)
        {
            if (DateTime.Now.Date.Month == 11)
            {
                return price * 0.95m;
            }

            return price;
        }
    }
}
