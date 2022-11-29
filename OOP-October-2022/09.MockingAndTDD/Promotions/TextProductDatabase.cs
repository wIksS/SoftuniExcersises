using Newtonsoft.Json;
using Promotions.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Promotions
{
    public class TextProductDatabase : IProductDatabase
    {
        private string path;

        public TextProductDatabase(string path = "../../../products.txt")
        {
            this.path = path;
        }
        public List<Product> GetAll()
        {
            using (StreamReader reader = new StreamReader(path))
            {
                return JsonConvert.DeserializeObject<List<Product>>(reader.ReadToEnd());
            }
        }

        public void Save(List<Product> products)
        {
            using (StreamWriter writer = new StreamWriter(path,false))
            {
                writer.Write(JsonConvert.SerializeObject(products,Formatting.Indented));
            }
        }
    }
}
