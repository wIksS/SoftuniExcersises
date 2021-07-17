namespace _03.PriorityQueue.Tests
{
    using NUnit.Framework;
    using System.Collections.Generic;

    public class PriorityQueueTests
    {
        [Test]
        public void TestDequeueSingleElement()
        {
            var priorityQueue = new PriorityQueue<int>();
            priorityQueue.Add(13);
            Assert.AreEqual(13, priorityQueue.Dequeue());
        }

        [Test]
        public void TestDequeueMultipleElements()
        {
            var queue = new PriorityQueue<int>();
            var elements = new List<int>() { 15, 25, 6, 9, 5, 8, 17, 16 };
            foreach (var element in elements)
            {
                queue.Add(element);
            }
            int[] expected = { 25, 17, 16, 15, 9, 8, 6, 5 };
            int index = 0;
            Assert.AreEqual(expected.Length, queue.Size);
            while (queue.Size != 0)
            {
                Assert.AreEqual(expected[index++], queue.Dequeue());
            }
        }
    }
}