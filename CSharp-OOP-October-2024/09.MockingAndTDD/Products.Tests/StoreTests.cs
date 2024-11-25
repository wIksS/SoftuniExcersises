using Moq;
using NUnit.Framework;
using Products.Contracts;
using Products.Tests.Fakes;
using System.Collections.Generic;

namespace Products.Tests
{
    public class StoreTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddProduct_ShouldBeSavedInDB()
        {
            Mock<IProductDatabase> mockDb = new Mock<IProductDatabase>();

            mockDb.Setup(m => m.LoadProducts())
                .Returns(new List<string>());

            Store store = new Store(mockDb.Object);

            store.AddProduct("Test Product");

            Assert.AreEqual(1, store.Products.Count);
            mockDb.Verify(m => m.Save(It.IsAny<List<string>>()), Times.Once);
            //Assert.AreEqual(1, fakeDB.SaveTimesCalled);
        }

        [Test]
        public void DeleteProduct_ShoulRemoveProduct()
        {
            Mock<IProductDatabase> mockDb = new Mock<IProductDatabase>();

            mockDb.Setup(m => m.LoadProducts())
                .Returns(new List<string>());

            Store store = new Store(mockDb.Object);

            store.AddProduct("Test Product");


            store.DeleteProduct("Test Product");

            Assert.AreEqual(0, store.Products.Count);

            mockDb.Verify(m => m.Save(It.IsAny<List<string>>()), Times.Exactly(2));
        }
    }
}