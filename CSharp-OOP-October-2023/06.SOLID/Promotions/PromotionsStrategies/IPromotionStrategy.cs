using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promotions.PromotionsStrategies
{
    public interface IPromotionStrategy
    {
        public decimal ApplyPromotion(decimal price);

        public bool IsValid();
    }
}
