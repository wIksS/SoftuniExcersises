using System;
using System.Collections.Generic;
using System.Text;

namespace Promotions.Contracts
{
    public interface IPromotionsService
    {
        public decimal GetPromotion(Product product);
    }
}
