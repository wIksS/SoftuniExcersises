using NUnit.Framework;

namespace TestSetupAndTeardown
{
    public class Tests
    {
        private int x = 55;

        [SetUp]
        public void Setup()
        {
            x = 55;
        }


        [Test]
        public void Test1()
        {
            x = 100;
            Assert.AreEqual(100, x);
        }


        [Test]
        public void Test2()
        {
            Assert.AreEqual(55, x);
        }

        [TearDown]
        public void CleanUp()
        {

        }
    }
}