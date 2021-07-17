namespace _02.MaxHeap.Tests
{
    using System.Collections.Generic;
    using NUnit.Framework;
    using _02.MaxHeap;

    public class MaxHeapTests
    {
        [Test]
        public void TestHeapifyUpAddOne()
        {
            var integerHeap = new MaxHeap<int>();
            integerHeap.Add(13);
            Assert.AreEqual(13, integerHeap.Peek());
        }

        [Test]
        public void TestHeapifyUpAddMany()
        {
            var integerHeap = new MaxHeap<int>();
            var elements = new List<int>() { 15, 6, 9, 5, 25, 8, 17, 16 };
            foreach (var el in elements)
            {
                integerHeap.Add(el);
            }
            Assert.AreEqual(25, integerHeap.Peek());
        }

        [Test]
        public void TestSizeShouldBeCorrect()
        {
            var integerHeap = new MaxHeap<int>();
            var elements = new List<int>() { 15, 25, 6, 9, 5, 8, 17, 16 };
            foreach (var el in elements)
            {
                integerHeap.Add(el);
            }
            Assert.AreEqual(8, integerHeap.Size);
        }
    }
}