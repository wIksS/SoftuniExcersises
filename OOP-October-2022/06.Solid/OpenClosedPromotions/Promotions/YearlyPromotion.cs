using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPromotions
{
    internal class YearlyPromotion : IPromotion
    {
        public decimal GetDiscount(Product product)
        {
            if (DateTime.Now.Year == 2022)
            {
                return 150;
            }

            return 0;
        }
    }
}
