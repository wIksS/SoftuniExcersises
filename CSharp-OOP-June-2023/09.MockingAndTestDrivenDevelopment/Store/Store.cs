using Store.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Store
    {
        private IProductDatabase database;

        public Store(IProductDatabase database)
        {
            this.database = database;
        }

        public List<Product> GetAllProducts()
        {
            return database.GetAll().ToList();
        }

        //"1 - Test1\r\n2 - Test2\r\n"
        public virtual string VisualiseAllProducts()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var item in database.GetAll())
            {
                stringBuilder.AppendLine($"{item.Id} - {item.Name}");
            }

            return stringBuilder.ToString();    
        }

        public void AddProduct(Product product)
        {
            database.Add(product);
            database.Save();
        }

    }
}
