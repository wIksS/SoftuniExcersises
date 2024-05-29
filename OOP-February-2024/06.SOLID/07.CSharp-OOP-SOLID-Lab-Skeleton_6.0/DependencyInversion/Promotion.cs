using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    internal class Promotion
    {
        //private DateTime date;

        //public Promotion(DateTime date)
        //{
        //    this.date = date;
        //}

        public int GetPromotion()
        {
            if (Date.DayOfWeek == DayOfWeek.Monday)
            {
                return 20;
            }

            return 0;
        }

        public DateTime Date { get; set; }
    }
}
