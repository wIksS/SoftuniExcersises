namespace _01.Loader.PerformanceTests
{
    using NUnit.Framework;
    using _01.Loader;
    using _01.Loader.Models;
    using System.Diagnostics;

    public class LoaderPerformanceTests
    {
        [Test]
        public void Swap_10000_Entities()
        {
            var buffer = new Loader();
            var sw = new Stopwatch();
            int count = 100000;
            for (int i = 0; i < count; i++)
            {
                buffer.Add(new Invoice(i, i + 10));
            }

            sw.Start();
            for (int i = 0; i < count - 10; i++)
            {
                buffer.Swap(new Invoice(i, i + 10), new User(i + 1, i + 11));
            }
            sw.Stop();

            
            Assert.IsTrue(sw.ElapsedMilliseconds <= -1, sw.ElapsedMilliseconds.ToString());
        }
    }
}