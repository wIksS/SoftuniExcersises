using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStorePromotions.Promotions
{
    internal class MondayPromotion : IPromotionStrategy
    {
        public decimal GetPromotionPrice(Product product, User user)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
            {
                return product.Price * 0.5m;
            }

            return 0;
        }
    }
}
