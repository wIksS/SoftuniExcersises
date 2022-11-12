using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionPromotions
{
    internal class Store
    {
        private DateTime dateToday;

        public Store(DateTime dateToday)
        {
            this.dateToday = dateToday;
        }

        public void Buy(Product product)
        {
            int discount = 0;

            if (dateToday.DayOfWeek == DayOfWeek.Tuesday)
            {
                discount += 20; 
            }

            Console.WriteLine($"Discount is {discount}lv");
        }
    }
}
