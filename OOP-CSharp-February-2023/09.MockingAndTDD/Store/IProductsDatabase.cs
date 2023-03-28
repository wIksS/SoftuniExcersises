using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stores
{
    public interface IProductsDatabase
    {
        IEnumerable<Product> GetAllProducts();

        void SaveProducts(IEnumerable<Product> products);
    }
}
