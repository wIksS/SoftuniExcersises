using P03._ShoppingCart;
using P03._ShoppingCart_Before.Contracts;
using P03._ShoppingCart_Before.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P03._ShoppingCart_Before
{
    class PriceCalculator
    {
        private readonly List<IPriceRule> promotionRules = new List<IPriceRule>()
        {
            new HappyFridayRule(),
            new SpecialRule(),
            new BlackFridayRule()
        };

        public decimal CalculatePrice(OrderItem item)
        {
            decimal total = 0;
            var promotionRule = promotionRules.FirstOrDefault(r => r.IsMatch(item));

            if (promotionRule == null)
            {
                total += item.Price;
            }
            else
            {
                total += promotionRule.CalculatePrice(item);
            }

            return total;
        }
    }
}
