namespace _02.Data.PerformanceTests
{
    using _02.Data.Models;
    using NUnit.Framework;
    using System.Diagnostics;

    public class DataPerformanceTests
    {
        [Test]
        public void PeekMostRecent_1000_Entities()
        {
            var data = new Data();
            var sw = new Stopwatch();
            for (int i = 0; i < 1000; i++)
            {
                data.Add(new Invoice(i, i + 10));
            }

            sw.Start();
            for (int i = 0; i < 1000; i++)
            {
                data.PeekMostRecent();
            }
            sw.Stop();

            Assert.IsTrue(sw.ElapsedMilliseconds <= 20);
        }

        [Test]
        public void CheckParentId()
        {
            var data = new Data();
            var sw = new Stopwatch();
            for (int i = 0; i < 1000; i++)
            {
                data.Add(new Invoice(i, i+1));
            }

            sw.Start();
            for (int i = 0; i < 1000; i++)
            {
                data.GetByParentId(i);
            }

            sw.Stop();

            Assert.IsTrue(sw.ElapsedMilliseconds <= 20);
        }

        [Test]
        public void GetById_1000()
        {
            var data = new Data();
            var sw = new Stopwatch();
            for (int i = 0; i < 5000; i++)
            {
                data.Add(new Invoice(i, i + 10));
            }

            sw.Start();
            for (int i = 0; i < 5000; i++)
            {
                data.GetById(i);
            }
            sw.Stop();

            Assert.IsTrue(sw.ElapsedMilliseconds <= 20);
        }
    }
}
