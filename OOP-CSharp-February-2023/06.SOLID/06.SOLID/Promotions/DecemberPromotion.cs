using OpenClosePrinciple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SOLID.Promotions
{
    public class DecemberPromotion : IPromotion
    {
        public decimal GetPrice(Product product)
        {
            decimal result = 0;

            if ((DateTime.Now.Month == 12 && product.Quantity > 50) || true)
            {
                result = product.Price * 0.8m;
                Console.WriteLine("Final licvidation");
            }

            return result;
        }
    }
}
