using Promotions.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Promotions
{
    public class ProductsService
    {
        private IProductDatabase productsDatabase;
        private IPromotionsService promotionsService;

        public ProductsService(IProductDatabase db, IPromotionsService promotionsService)
        {
            this.productsDatabase = db;
            this.promotionsService = promotionsService;

            Products = db.GetAll();
        }

        public List<Product> Products{ get; set; }

        public void Add(Product product)
        {
            Products.Add(product);

            productsDatabase.Save(Products);
        }

        public void Delete(int id)
        {
            Product product = FindById(id);
            if (product == null)
            {
                throw new ArgumentException("Product not found!");
            }

            Products.Remove(product);

            productsDatabase.Save(Products);
        }

        public List<Product> GetAllProductsForToday()
        {
            List<Product> productsWithPromotionsApplied = new List<Product>();

            foreach (var product in Products)
            {
                decimal price = promotionsService.GetPromotion(product);
                productsWithPromotionsApplied.Add(new Product(product.Id, product.Name, price));
            }

            return productsWithPromotionsApplied;
        }

        private Product FindById(int id)
        {
            return Products.FirstOrDefault(p => p.Id == id);
        }
    }
}
