using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculators.Tests
{
    class CalculatorTest
    {
        [Test]
        [TestCase(5, 6)]
        [TestCase(-100, 6)]
        [TestCase(0, 0)]
        [TestCase(333333, 44444444)]
        public void CalculatorAdd_ShouldReturnCorrectly(int a, int b)
        {
            Calculator calculator = new Calculator();

            int result = calculator.Add(a, b);

            Assert.AreEqual(a+b, result, $"Adding {a} and {b} should return {a+b} and not {result}");
        }

        
    }
}
