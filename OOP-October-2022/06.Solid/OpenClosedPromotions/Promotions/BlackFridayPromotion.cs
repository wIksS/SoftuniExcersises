using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPromotions
{
    internal class BlackFridayPromotion : IPromotion
    {
        public decimal GetDiscount(Product product)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
            {
                Console.WriteLine("Yay black friday!");
                return 1500;
            }

            return 0;
        }
    }
}
