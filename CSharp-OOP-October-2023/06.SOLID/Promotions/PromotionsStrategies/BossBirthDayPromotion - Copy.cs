using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promotions.PromotionsStrategies
{
    public class STValentinesPromotion : IPromotionStrategy
    {
        public decimal ApplyPromotion(decimal price)
        {
            Console.WriteLine("Applying ST Val promotion");

            return price - price * 0.5m;
        }

        public bool IsValid()
        {
            if (DateTime.Now.Month == 2 && DateTime.Now.Day == 14)
            {
                return true;
            }

            return false;
        }
    }
}
