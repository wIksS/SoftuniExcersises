using OpenClosePrinciple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SOLID.Promotions
{
    public class StValentinePromotion : IPromotion
    {
        public decimal GetPrice(Product product)
        {
            decimal result = 0;


            if ((DateTime.Now.Month == 2 && DateTime.Now.Day == 14) || true)
            {
                // 100 rows
                result = product.Price * 0.3m;
                Console.WriteLine("30% up because it is St Valentine! Ouch why do you wait until last minute??");
            }

            return result;
        }
    }
}
