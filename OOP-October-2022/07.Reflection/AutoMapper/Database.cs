using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AutoMapper
{
    internal class Database
    {
        private SerializeObject serializer = new SerializeObject();

        public void SaveProducts<T>(List<T> products)
        {
            using (StreamWriter writer = new StreamWriter("../../../db.txt",false))
            {
                foreach (var item in products)
                {
                    writer.Write(serializer.Serialize(item));
                }
            }
        }

        public List<T> LoadProducts<T>()
        {
            List<T> products = new List<T>();
            if (!File.Exists("../../../db.txt"))
            {
                return products;
            }
            using (StreamReader reader = new StreamReader("../../../db.txt"))
            {
                string data = reader.ReadToEnd();

                var productsSplitted = data.Split("&&|&&", StringSplitOptions.RemoveEmptyEntries);
                foreach (var product in productsSplitted)
                {
                    T newProduct = serializer.Deserialize<T>(product);

                    products.Add(newProduct);
                }
            }

            return products;
        }
    }
}
