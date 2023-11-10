using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependencies.Contracts
{
    public interface IPromotionService
    {
        public decimal GetPromotion(Product product);

    }
}
