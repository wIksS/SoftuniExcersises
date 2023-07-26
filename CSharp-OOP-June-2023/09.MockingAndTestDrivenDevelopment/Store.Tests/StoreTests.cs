using Moq;
using NUnit.Framework;
using Store.Contracts;
using Store.Tests.Fakes;
using System.Collections.Generic;

namespace Store.Tests
{
    public class StoreTests
    {
        [Test]
        public void TestVIsualiseAllProductsReturnsCorrectly()
        {
            Mock<IProductDatabase> dbMock = new Mock<IProductDatabase>();
            dbMock.Setup(db => db.GetAll())
                .Returns(new List<Product>() {
                new Product() { Name = "Test1", Id = 1 },
                new Product() { Name = "Test2", Id = 2 }
            });

            Store store = new Store(dbMock.Object);

            string data = store.VisualiseAllProducts();

            Assert.AreEqual("1 - Test1\r\n2 - Test2\r\n", data);
        }

        [Test]
        public void TestAddMethodCallsSaveDatabase()
        {
            Mock<IProductDatabase> dbMock = new Mock<IProductDatabase>();
            Store store = new Store(dbMock.Object);

            var product = new Product() { Name = "Test1", Id = 116 };

            store.AddProduct(product);

            dbMock.Verify(db => db.Save(), Times.Once());
            //Assert.AreEqual(1, db.saveMethodCalls);
        }

        
        [Test]
        public void TestAddMethodCallsAddToDatabase()
        {

            Mock<IProductDatabase> dbMock = new Mock<IProductDatabase>();
            Store store = new Store(dbMock.Object);

            var product = new Product() { Name = "Test1", Id = 116 };

            store.AddProduct(product);

            dbMock.Verify(db => db.Add(product));
            //Assert.AreEqual(116, db.AddedProduct.Id);
        }
    }
}