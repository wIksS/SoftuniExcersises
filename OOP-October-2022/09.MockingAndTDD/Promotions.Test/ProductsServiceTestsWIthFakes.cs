//using NUnit.Framework;
//using Promotions.Test.Fakes;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace Promotions.Test
//{
//    public class ProductsServiceTestsWIthFakes
//    {
//        private ProductsService service;
//        private DummyProductsDatabase dummyDb;
//        [SetUp]
//        public void SetUp()
//        {
//            dummyDb = new DummyProductsDatabase();
//            service = new ProductsService(dummyDb);
//        }

//        [Test]
//        public void Test_AddProduct()
//        {
//            service.Add(new Product(1, "TestProduct", 5));

//            Assert.AreEqual(4, service.Products.Count);
//            Assert.AreEqual(1, dummyDb.SaveCallTimes);
//        }

//        [Test]
//        public void Test_AddMultipleProduct()
//        {
//            service.Add(new Product(1, "TestProduct", 5));
//            service.Add(new Product(1, "TestProduct", 5));
//            service.Add(new Product(1, "TestProduct", 5));
//            service.Add(new Product(1, "TestProduct", 5));

//            Assert.AreEqual(7, service.Products.Count);
//            Assert.AreEqual(4, dummyDb.SaveCallTimes);
//        }


//        [Test]
//        public void Test_DeleteProduct()
//        {
//            service.Add(new Product(4, "TestProduct", 15));

//            service.Delete(4);

//            Assert.AreEqual(3, service.Products.Count);

//            Assert.AreEqual(false, service.Products.Any(x => x.Id == 4));
//        }
//    }
//}
