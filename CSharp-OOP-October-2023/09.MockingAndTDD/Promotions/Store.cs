using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promotions
{
    public class Store
    {
        private List<Product> products;
        private IPromotionsService promotionsService;

        public Store(List<Product> products, IPromotionsService promotionsService)
        {
            this.products = products;
            this.promotionsService = promotionsService;
        }

        public decimal GetProductPrice(string name)
        {
            var product = products.First(p => p.Name == name);

            return promotionsService.GetPrice(product.Price);
        }
    }
}
