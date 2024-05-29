using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopPromotions
{
    public class Database<T> : IDatabase<T>
    {
        private string path = @"C:\Users\Viktor\Desktop\Work\SoftuniExcersises\OOP-February-2024\10.MockingAndTestDrivenDevelopment\OnlineShopPromotions\db.txt";

        public List<T> GetAll()
        {
            if (!File.Exists(path))
            {
                return new List<T>();
            }
            using (StreamReader reader = new StreamReader(path))
            {
                return JsonConvert.DeserializeObject<List<T>>(reader.ReadToEnd());
            }
        }

        public void Save(List<T> products)
        {
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.WriteLine(JsonConvert.SerializeObject(products, Formatting.Indented));
            }
        }
    }
}
