using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStorePromotions.Promotions
{
    internal class WomensDayPromotion : IPromotionStrategy
    {
        public decimal GetPromotionPrice(Product product, User user)
        {
            if (DateTime.Now.Month == 3 && DateTime.Now.Day == 8)
            {
                return product.Price * 0.8m;
            }

            return 0;
        }
    }
}
