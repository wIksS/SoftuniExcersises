using Newtonsoft.Json;
using Store.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class ProductTextDatabase : IProductDatabase
    {
        private string dbPath = @"C:\Users\Viktor\Desktop\Work\HeartsData\09.MockingAndTestDrivenDevelopment\Store\products-db.txt";
        private List<Product> products;

        public ProductTextDatabase()
        {
            products = Load();
        }

        public void Add(Product product)
        {
            products.Add(product);
        }

        public bool Delete(Product product)
        {
            return products.Remove(product);
        }

        public IEnumerable<Product> GetAll()
        {
            return products;
        }

        public void Save()
        {
            using (StreamWriter writer = new StreamWriter(dbPath))
            {
                writer.Write(JsonConvert.SerializeObject(products));
            }
        }

        private List<Product> Load()
        {
            if (!File.Exists(dbPath))
            {
                return new List<Product>();
            }

            string productsData = "";
            using (StreamReader reader = new StreamReader(dbPath))
            {
                productsData = reader.ReadToEnd();  
            }

            return JsonConvert.DeserializeObject<List<Product>>(productsData);
        }
    }
}
