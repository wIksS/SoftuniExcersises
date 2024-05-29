using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStorePromotions
{
    internal interface IPromotionStrategy
    {
        decimal GetPromotionPrice(Product product, User user);
    }
}
