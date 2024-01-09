using Promotions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promotion.Tests.Fakes
{
    internal class FakePromotionsService : IPromotionsService
    {
        public decimal GetPrice(decimal price)
        {
            return price - price * 0.2m;
        }
    }
}
