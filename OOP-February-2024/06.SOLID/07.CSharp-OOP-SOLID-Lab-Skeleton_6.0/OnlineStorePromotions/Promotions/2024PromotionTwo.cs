using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStorePromotions.Promotions
{
    internal class _2024PromotionTwo : IPromotionStrategy
    {
        public decimal GetPromotionPrice(Product product, User user)
        {
            if (DateTime.Now.Year == 2024)
            {
                return product.Price * 105.3m * -1;
            }

            return 0;
        }
    }
}
