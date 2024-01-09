using Moq;
using NUnit.Framework;
using Promotion.Tests.Fakes;
using Promotions;
using System;
using System.Collections.Generic;

namespace Promotion.Tests
{
    public class StoreTests
    {
        private List<Product> products;
        private Store store;
        private Mock<IPromotionsService> mockPromotions;

        [SetUp]
        public void Setup()
        {
            mockPromotions = new Mock<IPromotionsService>();

            mockPromotions.Setup(p => p.GetPrice(It.IsAny<decimal>()))
                .Returns((decimal value) => value - value * 0.2m);

            products = new List<Product>()
            {
                new Product(){ Name = "C# OOP", Price =100},
                new Product(){ Name = "C# Advanced", Price =120}
            };

            store = new Store(products, mockPromotions.Object);
        }

        [Test]
        public void When_GetProductPrice_ReturnCorrectPrice_ForAProduct()
        {
            Assert.AreEqual(80, store.GetProductPrice(products[0].Name));
            mockPromotions.Verify(p => p.GetPrice(It.IsAny<decimal>()), Times.Exactly(1));
        }

        [Test]
        public void When_GetProductPrice_IsCalledWithInvalidProduct_Throws()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                store.GetProductPrice("Non Existing");
            });
        }
    }
}