using NUnit.Framework;
using System;

namespace UnitTestingTests
{
    public class FirstTest
    {
        int x = 0;
        [SetUp]
        public void Setup()
        {
            x++;
        }

        [Test]
        public void Test()
        {
            Assert.AreEqual(1, x);
            int result = 1 + 6;
            Assert.AreEqual(7, result, "1 + 6 should equal to 7");

            Assert.AreEqual(5,5);

            //Assert.(5 == 6);
            Assert.Throws(typeof(ArgumentException),() =>
            {
                int x = 5;
                throw new ArgumentException();
            });


            Assert.Pass();


        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(2, x);

            int result = 1 + 6;
            Assert.AreEqual(7, result, "1 + 6 should equal to 7");
        }
    }
}