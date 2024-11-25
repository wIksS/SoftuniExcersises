using Products.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    public class Store
    {
        private IProductDatabase productDatabase;

        public Store(IProductDatabase productDatabase)
        {
            this.productDatabase = productDatabase;
            Products = productDatabase.LoadProducts();
        }

        public List<string> Products{ get; set; }

        public void AddProduct(string productName)
        {
            if (String.IsNullOrWhiteSpace(productName))
            {
                throw new ArgumentException("Name cannot be empty");
            }

            Products.Add(productName);

            productDatabase.Save(Products);
        }

        public void DeleteProduct(string productName)
        {
            Products.Remove(productName);

            productDatabase.Save(Products);
        }
    }
}
