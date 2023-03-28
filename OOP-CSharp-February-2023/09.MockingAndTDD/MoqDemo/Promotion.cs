using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqDemo
{
    class Promotion : IPromotion
    {
        public int GetPromotion()
        {
            DateTime dateToday = DateTime.Now;
            if (dateToday.DayOfWeek == DayOfWeek.Sunday)
            {
                return 19;
            }
            if (dateToday.DayOfWeek == DayOfWeek.Friday)
            {
                return 50;
            }
            if (dateToday.DayOfWeek == DayOfWeek.Monday)
            {
                return 30;
            }

            return 0;
        }
    }
}
