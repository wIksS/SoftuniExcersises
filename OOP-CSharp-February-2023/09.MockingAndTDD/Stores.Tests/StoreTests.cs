using Moq;
using NUnit.Framework;
using Stores.Tests.Fakes;
using System.Collections.Generic;
using System.Linq;

namespace Stores.Tests
{
    public class StoreTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetCheapest_ReturnsTheProductWithLowestPrice()
        {
            Mock<IProductsDatabase> db = new Mock<IProductsDatabase>();

            db.Setup(db => db.GetAllProducts()).Returns(new List<Product>()
            {
                new Product("T1",15,2),
                new Product("T2",20,0),
                new Product("T3",5,10),
            });

            Store store = new Store(db.Object);

            Product product = store.GetCheapest();

            Assert.AreEqual(5, product.Price);
            Assert.AreEqual("T3", product.Name);
        }

        [Test]
        public void AddingProductSavesCorrectlyToDatabase()
        {
            Mock<IProductsDatabase> db = new Mock<IProductsDatabase>();
            db.Setup(db => db.SaveProducts(It.IsAny<IEnumerable<Product>>()))
               .Callback((IEnumerable<Product> products) =>
               {
                   Assert.AreEqual(1, products.ToList().Count);
               });

            Store store = new Store(db.Object);

            Product product = new Product("T3", 5, 10);
            store.AddProduct(product);



            db.Verify(db => db.SaveProducts(It.IsAny<IEnumerable<Product>>()), Times.Once);

        }
    }
}