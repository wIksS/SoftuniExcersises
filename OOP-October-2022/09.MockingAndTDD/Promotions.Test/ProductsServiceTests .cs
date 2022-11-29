using Moq;
using NUnit.Framework;
using Promotions.Contracts;
using Promotions.Test.Fakes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Promotions.Test
{
    public class ProductsServiceTests
    {
        private ProductsService service;
        private Mock<IProductDatabase> mockDb;
        private Mock<IPromotionsService> mockPromotions;
        [SetUp]
        public void SetUp()
        {
            mockDb = new Mock<IProductDatabase>();
            mockPromotions = new Mock<IPromotionsService>();

            mockDb.Setup(db => db.GetAll()).Returns(new List<Product>());
            service = new ProductsService(mockDb.Object, mockPromotions.Object);
        }

        [Test]
        public void Test_AddProduct()
        {
            service.Add(new Product(1, "TestProduct", 5));

            Assert.AreEqual(1, service.Products.Count);
            mockDb.Verify(db => db.Save(It.IsAny<List<Product>>()), Times.Once);
        }

        [Test]
        public void Test_AddMultipleProduct()
        {
            service.Add(new Product(1, "TestProduct", 5));
            service.Add(new Product(1, "TestProduct", 5));
            service.Add(new Product(1, "TestProduct", 5));
            service.Add(new Product(1, "TestProduct", 5));

            Assert.AreEqual(4, service.Products.Count);
            mockDb.Verify(db => db.Save(It.IsAny<List<Product>>()), Times.Exactly(4));
        }


        [Test]
        public void Test_DeleteProduct()
        {
            service.Add(new Product(4, "TestProduct", 15));

            service.Delete(4);

            Assert.AreEqual(0, service.Products.Count);

            Assert.AreEqual(false, service.Products.Any(x => x.Id == 4));
        }

        [Test]
        public void Test_GetAllProducts_ShouldSetPromotionCorrectly()
        {
            service.Add(new Product(4, "TestProduct", 100));

            mockPromotions.Setup(pr => pr.GetPromotion(It.IsAny<Product>()))
                .Returns(20);

            List<Product> products = service.GetAllProductsForToday();

            Assert.AreEqual(20, products[0].Price);
        }
    }
}
