using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion
{
    class Promotion
    {
        private DateTime today;

        public Promotion(DateTime today)
        {
            this.today = today;
        }

        public string GetPromotion(DateTime today)
        {
            if (today.DayOfWeek == DayOfWeek.Friday)
            {
                return "Happy Friday promotion";
            }
            if (today.DayOfWeek == DayOfWeek.Saturday)
            {
                return "Weekend promotion";
            }

            return "No promotion for you";
        }
    }
}
