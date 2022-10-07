using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CustomHashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //    Console.WriteLine("5".GetHashCode());
        //    Console.WriteLine("6".GetHashCode());
        //    Console.WriteLine("7".GetHashCode());

            int n = 10000;
            int x = 100000;

            TestSoftuniHashSet(n, x);
            TestHashSet(n, x);
            TestDictionary(n, x);
            TestList(n, x);
        }

        static void TestSoftuniHashSet(int n, int x)
        {
            SoftuniHashSet hashSet = new SoftuniHashSet(n + n);

            Stopwatch watch = new Stopwatch();
            watch.Start();
            for (int i = 0; i < n; i++)
            {
                hashSet.Add(i.ToString());
            }

            for (int i = 0; i < x; i++)
            {
                hashSet.Contains(i.ToString());
            }
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
            watch.Reset();
        }

        static void TestList(int n, int x)
        {
            List<string> list = new List<string>();

            Stopwatch watch = new Stopwatch();
            watch.Start();
            for (int i = 0; i < n; i++)
            {
                list.Add(i.ToString());
            }

            for (int i = 0; i < x; i++)
            {
                list.Contains(i.ToString());
            }
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
            watch.Reset();
        }

        static void TestHashSet(int n, int x)
        {
            HashSet<string> hashSet = new HashSet<string>(n + n);

            Stopwatch watch = new Stopwatch();
            watch.Start();
            for (int i = 0; i < n; i++)
            {
                hashSet.Add(i.ToString());
            }

            for (int i = 0; i < x; i++)
            {
                hashSet.Contains(i.ToString());
            }
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
            watch.Reset();
        }

        static void TestDictionary(int n, int x)
        {
            Dictionary<string,int> dict = new Dictionary<string, int>();

            Stopwatch watch = new Stopwatch();
            watch.Start();
            for (int i = 0; i < n; i++)
            {
                dict.Add(i.ToString(),i);
            }

            for (int i = 0; i < x; i++)
            {
                dict.ContainsKey(i.ToString());
            }
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
            watch.Reset();
        }
    }
}
