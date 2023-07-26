using _09.MockingAndTestDrivenDevelopment;
using NUnit.Framework;
using System;

namespace Promotions.Tests
{
    public class PromotionTests
    {

        [Test]
        public void PromotionIs20PercentWhenMonday()
        {
            Promotion promotion=  new Promotion();

            Assert.AreEqual(10, promotion.GetPromotionPercentage(DayOfWeek.Monday));
        }

        [Test]
        public void PromotionIs30PercentWhenMonday()
        {
            Promotion promotion = new Promotion();

            Assert.AreEqual(30, promotion.GetPromotionPercentage(DayOfWeek.Tuesday));
        }
    }
}