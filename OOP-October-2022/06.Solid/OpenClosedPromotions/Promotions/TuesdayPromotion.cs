using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPromotions
{
    internal class TuesdayPromotion : IPromotion
    {
        public decimal GetDiscount(Product product)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday)
            {
                return 20;
            }

            return 0;
        }
    }
}
