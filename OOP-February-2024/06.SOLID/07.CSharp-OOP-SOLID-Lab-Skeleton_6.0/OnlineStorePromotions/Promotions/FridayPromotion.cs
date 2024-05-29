using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStorePromotions.Promotions
{
    internal class FridayPromotion : IPromotionStrategy
    {
        public decimal GetPromotionPrice(Product product, User user)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
            {
                return product.Price * 0.3m;
            }

            return 0;
        }
    }
}
