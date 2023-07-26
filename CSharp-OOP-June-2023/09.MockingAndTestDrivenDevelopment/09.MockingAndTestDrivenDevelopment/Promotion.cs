using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MockingAndTestDrivenDevelopment
{
    public class Promotion
    {
        public decimal GetPromotionPercentage(DayOfWeek dayOfWeek)
        {
            if (dayOfWeek == DayOfWeek.Sunday)
            {
                return 30;
            }
            if (dayOfWeek == DayOfWeek.Wednesday)
            {
                return 40;
            }
            if (dayOfWeek == DayOfWeek.Friday)
            {
                return 20;
            }
            if (dayOfWeek == DayOfWeek.Monday)
            {
                return 10;
            }

            return 0;
        }
    }
}
