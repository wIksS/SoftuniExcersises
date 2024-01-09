using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promotions
{
    public interface IPromotionsService
    {
        public decimal GetPrice(decimal price);
    }
}
