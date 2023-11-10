using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promotions.PromotionsStrategies
{
    public class BossBirthDayPromotion : IPromotionStrategy
    {
        public decimal ApplyPromotion(decimal price)
        {
            Console.WriteLine("Applying Boss birthday promotion");

            return price - price * 0.9m;
        }

        public bool IsValid()
        {
            if (DateTime.Now.DayOfYear == 156 || true)
            {
                return true;
            }

            return false;
        }
    }
}
