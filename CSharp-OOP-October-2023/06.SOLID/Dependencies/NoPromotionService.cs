using Dependencies.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependencies
{
    public class NoPromotionService : IPromotionService
    {
        public decimal GetPromotion(Product product)
        {

            return product.Price;
        }
    }
}
