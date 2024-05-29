using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStorePromotions.Promotions
{
    internal class MondayAprilKidsPromotion : IPromotionStrategy
    {
        public decimal GetPromotionPrice(Product product, User user)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday && DateTime.Now.Month == 4 && user.Age < 18)
            {
                return product.Price * 0.4m;
            }

            return 0;
        }
    }
}
