using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stores
{
    public class ProductsDatabase : IProductsDatabase
    {
        private string dbPath = "../../../products.txt";

        public IEnumerable<Product> GetAllProducts()
        {
            using (StreamReader reader = new StreamReader(dbPath))
            {
                return JsonConvert.DeserializeObject<List<Product>>(reader.ReadToEnd());    
            }
        }

        public void SaveProducts(IEnumerable<Product> products)
        {
            using (StreamWriter writer = new StreamWriter(dbPath))
            {
                writer.WriteLine(JsonConvert.SerializeObject(products, Formatting.Indented));
            }
        }
    }
}
