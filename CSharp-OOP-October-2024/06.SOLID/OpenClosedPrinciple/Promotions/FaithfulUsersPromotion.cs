using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.Promotions
{
    public class FaithfulUsersPromotion : IPromotion
    {
        public decimal GetPrice(decimal price)
        {
            Console.WriteLine("Checking if user has been with us over 5 years");
            //
            //
            //
            Console.WriteLine("Checking if user has spent over 5000lv");
            //
            //
            //
            Console.WriteLine("Checking age > 30");
            //
            //
            //

            return price * 0.9m;
        }
    }
}
