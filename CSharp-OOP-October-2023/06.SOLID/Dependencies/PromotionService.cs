using Dependencies.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependencies
{
    public class PromotionService : IPromotionService
    {
        public decimal GetPromotion(Product product)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
            {
                return product.Price - product.Price * 0.2m;
            }

            return product.Price;
        }
    }
}
