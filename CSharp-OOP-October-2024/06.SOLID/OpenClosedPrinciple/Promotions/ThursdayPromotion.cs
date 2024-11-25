using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.Promotions
{
    public class ThursdayPromotion : IPromotion
    {
        public decimal GetPrice(decimal price)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Thursday)
            {
                price *= 0.8m;
            }

            return price;
        }
    }
}
