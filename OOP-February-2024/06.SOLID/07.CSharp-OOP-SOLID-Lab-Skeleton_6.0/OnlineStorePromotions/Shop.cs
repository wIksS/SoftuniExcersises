using OnlineStorePromotions.Promotions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStorePromotions
{
    internal class Shop
    {
        private List<IPromotionStrategy> promotions;

        public Shop(List<IPromotionStrategy> promotions)
        {
            this.promotions = promotions;
        }

        public List<Product> Products { get; set; }

        public decimal GetPrice(Product product, User user)
        {
            var promotionPrice = product.Price;
            foreach (var promotion in promotions)
            {
                promotionPrice -= promotion.GetPromotionPrice(product, user);
            }

            return promotionPrice;
        }
    }
}
