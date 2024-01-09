using NUnit.Framework;
using Promotions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promotion.Tests
{
    internal class PromotionsServiceTests
    {
        private PromotionsService promotionsService;


        [SetUp]
        public void Setup()
        {
            promotionsService = new PromotionsService();    
        }

        [Test]
        public void When_Tuesday_Promotion_Discount_ShouldBe_TwentyPercent()
        {
            promotionsService = new PromotionsService(new DateTime(2023, 11, 21));
            Assert.AreEqual(80, promotionsService.GetPrice(100));
        }

        [Test]
        public void When_Friday_Promotion_Discount_ShouldBe_EightyPercent()
        {
            promotionsService = new PromotionsService(new DateTime(2023, 11, 24));

            Assert.AreEqual(20, promotionsService.GetPrice(100));
        }
    }
}
