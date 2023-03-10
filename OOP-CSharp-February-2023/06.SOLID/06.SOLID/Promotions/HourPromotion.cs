using OpenClosePrinciple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SOLID.Promotions
{
    public class HourPromotion : IPromotion
    {
        public decimal GetPrice(Product product)
        {
            decimal result = 0;
            if (DateTime.Now.Hour > 20)
            {
                result -= product.Price * 0.1m;
                Console.WriteLine("After 8 pm");
            }

            return result;
        }
    }
}
