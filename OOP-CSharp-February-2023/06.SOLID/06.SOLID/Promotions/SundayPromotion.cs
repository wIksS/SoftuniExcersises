using OpenClosePrinciple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SOLID.Promotions
{
    public class SundayPromotion : IPromotion
    {
        public decimal GetPrice(Product product)
        {
            decimal result = 0;

            if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday || true)
            {
                result = product.Price * 0.5m;
                Console.WriteLine("50% off because it is Monday! yay");
            }

            return result;
        }
    }
}
