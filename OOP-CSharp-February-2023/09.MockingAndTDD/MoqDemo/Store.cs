using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqDemo
{
    internal class Store
    {
        private IPromotion promotion;

        public Store(IPromotion promotion)
        {
            this.promotion = promotion;
        }
    }
}
