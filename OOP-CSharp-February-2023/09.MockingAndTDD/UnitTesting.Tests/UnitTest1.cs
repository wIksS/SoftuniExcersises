using NUnit.Framework;

namespace UnitTesting.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.That(1 == 1);
            Assert.AreEqual(1, 1);
        }
    }
}