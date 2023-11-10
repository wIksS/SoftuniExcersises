using Dependencies.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependencies
{
    public class Store
    {
        // always rely on abstraction
        private List<Product> products;
        private IPromotionService promotionService;
        public Store(IPromotionService service, List<Product> products)
        {
            this.products = products;
            promotionService = service;
        }

        public void PrintProducts()
        {
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name} : {promotionService.GetPromotion(product)}");
            }
        }
    }
}
