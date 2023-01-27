using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureFunctions
{
    internal class Store
    {
        public static int cashToday;

        public static int GetPromotion()
        {
            if (cashToday > 1000)
            {
                return 40;
            }
            if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                //side effect
                cashToday += 200;
                return 20;
            }
            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
            {
                cashToday += 100;
                return 30;
            }

            return 0;
        }
    }

    internal class PureStore
    {
        public static int cashToday;

        public static int GetPromotionPercentage(DateTime day, int cashToday)
        {
            return GetPromotionBasedOnCash(cashToday) + GetPromotionBasedOnDay(day);
        }

        public static int GetPromotionBasedOnDay(DateTime day)
        {
            if (day.DayOfWeek == DayOfWeek.Sunday)
            {
                return 20;
            }
            if (day.DayOfWeek == DayOfWeek.Monday)
            {
                return 30;
            }

            return 0;
        }

        public static int GetPromotionBasedOnCash(int cashToday)
        {
            if (cashToday > 1000)
            {
                return 40;
            }

            return 0;
        }
    }
}
