using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPromotions
{
    public interface IPromotion
    {
        public decimal GetDiscount(Product product);
    }
}
