using NUnit.Framework;

namespace Promotions.Tests
{
    [TestFixture]
    public class PromotionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Promotion_ShouldReturn_20_WhenMonday()
        {
            //Promotion promotion = new Promotion();

            //Assert.AreEqual(20, promotion.GetPromotionPercentage());
            Assert.That(5, Is.False, "1 should not be prime");

        }
    }
}