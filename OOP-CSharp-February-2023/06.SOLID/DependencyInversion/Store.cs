using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class Store
    {
        public string GetPromotionToday()
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
            {
                return "Ponedelnishkata promociq";
            }
            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
            {
                return "Petychnata promociq";
            }
            if (DateTime.Now.Year == 2030)
            {
                return "Promocionalna godina";
            }

            return "nqma promociq :(";
        }

        public string GetPromotionTodayDI(DateTime dateToday)
        {
            if (dateToday.DayOfWeek == DayOfWeek.Monday)
            {
                return "Ponedelnishkata promociq";
            }
            if (dateToday.DayOfWeek == DayOfWeek.Friday)
            {
                return "Petychnata promociq";
            }
            if (dateToday.Year == 2025)
            {
                return "Promocionalna godina";
            }

            return "nqma promociq :(";
        }
    }
}
