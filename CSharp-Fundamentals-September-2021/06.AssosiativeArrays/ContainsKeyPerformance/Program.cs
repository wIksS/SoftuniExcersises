using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ContainsKeyPerformance
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();

            List<int> numbers = new List<int>();

            for (int i = 0; i < 100000; i++)
            {
                numbers.Add(i);
                students.Add(i, i.ToString());
            }

            Stopwatch watch = new Stopwatch();

            watch.Start();
            for (int i = 0; i < 500000; i++)
            {
                numbers.Contains(i);
            }

            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
            watch.Reset();
            watch.Start();
            for (int i = 0; i < 500000; i++)
            {
                students.ContainsKey(i);
            }

            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
        }
    }
}
