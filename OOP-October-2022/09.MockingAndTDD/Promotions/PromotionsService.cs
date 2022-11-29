using Promotions.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Promotions
{
    public class PromotionsService : IPromotionsService
    {
        private DateTime dateToday;

        public PromotionsService(DateTime dateToday)
        {
            this.dateToday = dateToday;
        }

        public decimal GetPromotion(Product product)
        {
            decimal percentage = 0;
            if (dateToday.DayOfWeek == DayOfWeek.Tuesday)
            {
                percentage = 20;
            }
            if (dateToday.DayOfWeek == DayOfWeek.Wednesday)
            {
                percentage = 35;
            }
            if (dateToday.DayOfWeek == DayOfWeek.Sunday)
            {
                percentage = 100;
            }

            return product.Price - (percentage / 100 * product.Price);
        }
    }
}
