using OpenClosePrinciple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SOLID.Promotions
{
    public class MondayPromotion : IPromotion
    {
        public decimal GetPrice(Product product)
        {
            decimal result = 0;


            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday || true)
            {
                result = product.Price * 0.2m;
                Console.WriteLine("20% off because it is Monday! yay");
            }

            return result;
        }
    }
}
