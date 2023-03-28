using NUnit.Framework;
using System;

namespace Promotions.Tests
{
    public class Tests
    {


        [Test]
        public void TestPromotionIs30PercentOnMonday()
        {
            PromotionService promotionService = new PromotionService();

            Assert.AreEqual(30, promotionService.GetPromotionPercentage(new DateTime(2023,3,20)));
        }

        [Test]
        public void TestPromotionIs20PercentOnSunday()
        {
            PromotionService promotionService = new PromotionService();

            Assert.AreEqual(20, promotionService.GetPromotionPercentage(new DateTime(2023, 3, 19)));
        }
    }
}