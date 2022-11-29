using NUnit.Framework;
using System;

namespace PromotionsTests
{
    public class PromotionsTest
    {
        private Promotions promotions;
        [SetUp]
        public void Setup()
        {
            promotions = new Promotions();
        }

        [Test]
        public void TestPromotionTodayShouldReturn10()
        {
            var result = promotions.GetPromotion(new DateTime(2022,11,18));

            Assert.AreEqual(10, result);
        }
    }
}