using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopPromotions
{
    public class Promotion
    {
        private DateTime dateToday;

        public Promotion(DateTime dateToday)
        {
            this.dateToday = dateToday;
        }

        // poor man's dependency inversion
        public Promotion() : this(DateTime.Now)
        {

        }

        public decimal GetDiscountedPrice(decimal price)
        {
            if (dateToday.Day == 1 && dateToday.Month == 4 && dateToday.Year == 2030)
            {
                return price + price * 1.5m;
            }
            if (dateToday.DayOfWeek == DayOfWeek.Tuesday)
            {
                return price - price * 0.3m;
            }
            if (dateToday.DayOfWeek == DayOfWeek.Friday)
            {
                return price - price * 0.5m;
            }
            if (dateToday.Day == 1 && dateToday.Month == 4)
            {
                return price + price * 0.5m;
            }
  

            return price;
        }
    }
}
