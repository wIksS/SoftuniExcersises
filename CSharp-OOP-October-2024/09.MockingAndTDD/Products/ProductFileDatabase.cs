using Newtonsoft.Json;
using Products.Contracts;

namespace Products
{
    public class ProductFileDatabase : IProductDatabase
    {
        public void Save(List<string> products)
        {
            using (StreamWriter writer = new StreamWriter(@"C:\Users\Viktor\Desktop\Work\SoftuniExcersises\CSharp-OOP-October-2024\09.MockingAndTDD\Products\db.txt"))
            {
                Console.WriteLine(JsonConvert.SerializeObject(products));
                writer.WriteLine(JsonConvert.SerializeObject(products));
            }
        }


        public List<string> LoadProducts()
        {
            if (!File.Exists(@"C:\Users\Viktor\Desktop\Work\SoftuniExcersises\CSharp-OOP-October-2024\09.MockingAndTDD\Products\..\..\..\db.txt"))
            {
                return new List<string>();
            }

            using (StreamReader reader = new StreamReader(@"C:\Users\Viktor\Desktop\Work\SoftuniExcersises\CSharp-OOP-October-2024\09.MockingAndTDD\Products\db.txt"))
            {
                string products = reader.ReadLine();

                List<string> productsList = JsonConvert.DeserializeObject<List<string>>(products);

                return productsList;
            }
        }
    }
}