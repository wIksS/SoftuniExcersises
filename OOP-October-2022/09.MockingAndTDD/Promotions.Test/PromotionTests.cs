using NUnit.Framework;
using System;

namespace Promotions.Test
{
    public class PromotionTests
    {
        [Test]
        [TestCase("22/11/2022", 20)]
        [TestCase("23/11/2022", 0)]
        public void Test_TuesdayPromotion_ShouldReturn_20(string date, decimal result)
        {
            DateTime dateToday = DateTime.Parse(date);
            PromotionsService promotion = new PromotionsService(dateToday);

            Assert.AreEqual(result, promotion.GetPromotion(new Product(1,"",5)));
        }
    }
}