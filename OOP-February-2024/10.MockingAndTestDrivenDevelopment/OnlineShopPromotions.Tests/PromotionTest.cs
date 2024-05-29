using NUnit.Framework;
using System;

namespace OnlineShopPromotions.Tests
{
    public class PromotionTest
    {

        [Test]
        public void FridayPromotion_ShouldBe50Percent()
        {
            Promotion promotion = new Promotion(new DateTime(2024, 03, 22));

            Assert.AreEqual(50, promotion.GetDiscountedPrice(100));
        }

        [Test]
        public void FirstOfApril2030Promotion_ShouldBe150Percent()
        {
            Promotion promotion = new Promotion(new DateTime(2030, 4, 1));

            Assert.AreEqual(250, promotion.GetDiscountedPrice(100));
        }
    }
}