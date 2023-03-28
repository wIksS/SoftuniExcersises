using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stores.Tests.Fakes
{
    internal class FakeProductsDatabase : IProductsDatabase
    {
        public IEnumerable<Product> GetAllProducts()
        {
            return new List<Product>()
            {
                new Product("T1",15,2),
                new Product("T2",20,0),
                new Product("T3",5,10),
            };
        }

        public void SaveProducts(IEnumerable<Product> products)
        {
            
        }
    }
}
