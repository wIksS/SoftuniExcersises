using NUnit.Framework;
using Promotions;
using System;

namespace PromotionsProject.Tests
{
    public class PromotionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Promotion_ShouldReturn_20_WhenMonday()
        {
            Promotion promotion = new Promotion(new DateTime(2024, 11,18));

            Assert.AreEqual(20, promotion.GetPromotionPercentage());
        }

        [Test]
        public void Promotion_ShouldReturn_0_WhenFriday()
        {
            Promotion promotion = new Promotion(new DateTime(2024, 11, 21));

            Assert.AreEqual(0, promotion.GetPromotionPercentage());
        }
    }
}