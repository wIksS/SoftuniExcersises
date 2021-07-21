using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Performance
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            List<int> list = new List<int>();
            int n = 300000;
            for (int i = 0; i < n; i++)
            {
                dictionary.Add(i, i);
                list.Add(i);
            }

            Stopwatch timer = new Stopwatch();
            timer.Start();
            for (int i = 0; i < n; i++)
            {
                list.Contains(i);
            }

            timer.Stop();
            Console.WriteLine($"Contains With List: " + timer.ElapsedMilliseconds);

            timer.Reset();
            timer.Start();

            for (int i = 0; i < n; i++)
            {
                dictionary.ContainsKey(i);
            }

            timer.Stop();
            Console.WriteLine($"Contains With Dictionary: " + timer.ElapsedMilliseconds);
        }
    }
}
