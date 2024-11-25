using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promotions
{
    public class Promotion
    {
        private DateTime dateToday;

        public Promotion(DateTime dateToday)
        {
            this.dateToday = dateToday;
        }

        public int GetPromotionPercentage()
        {
            if (dateToday.DayOfWeek == DayOfWeek.Monday)
            {
                return 20;
            }

            return 0;
        }
    }
}
