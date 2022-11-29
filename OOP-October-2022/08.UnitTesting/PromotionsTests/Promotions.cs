using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionsTests
{
    internal class Promotions
    {
        public decimal GetPromotion(DateTime date)
        {
            if (date.DayOfWeek == DayOfWeek.Sunday)
            {
                return 50;
            }
            else if(date.DayOfWeek == DayOfWeek.Saturday)
            {
                return 40;
            }
            else if (date.DayOfWeek == DayOfWeek.Friday)
            {
                return 10;
            }

            return 0;
        }
    }
}
