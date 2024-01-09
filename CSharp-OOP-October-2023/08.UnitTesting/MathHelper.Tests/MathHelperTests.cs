
using NUnit.Framework;

namespace MathHelper.Tests
{
    public class MathHelperTests
    {
        [Test]
        public void Sum_Should_Sum_Correctly()
        {
            MathsHelper helper = new MathsHelper();

            Assert.AreEqual(10, helper.Sum(5, 5), "ne mojesh da syberesh dve chisla??");
        }

        [Test]
        public void Sum_Should_Work_Correctly_With_Negative_Numbers()
        {
            MathsHelper helper = new MathsHelper();

            Assert.AreEqual(-11, helper.Sum(-5, -6), "ne mojesh da syberesh dve chisla??");
        }
    }
}
