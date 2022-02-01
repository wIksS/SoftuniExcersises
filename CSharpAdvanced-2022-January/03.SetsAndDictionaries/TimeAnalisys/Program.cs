using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;

namespace TimeAnalisys
{
    class Program
    {
        static void Main(string[] args)
        {
               
            SoftuniHashSet<string> set = new SoftuniHashSet<string>();
            HashSet<int> x;

            set.Add("Pepi");
            set.Add("Pepi1");
            set.Add("Pepi2");

            Console.WriteLine(set.Contains("Pepi"));
            Console.WriteLine(set.Contains("Pepi1"));
            Console.WriteLine(set.Contains("Pepi2"));
            Console.WriteLine(set.Contains("Pepi23"));
            ////for (int i = 0; i < 100; i++)
            ////{
            ////    set.Add(i);
            ////}
            //set.Add(5);
            //set.Add(7);
            //set.Add(6);
            //set.Add(9);
            //set.Add(12); 
            //set.Add(3);

            //Console.WriteLine(set.Contains(5));
            //Console.WriteLine(set.Contains(6));
            //Console.WriteLine(set.Contains(7));
            //Console.WriteLine(set.Contains(8));
            //Console.WriteLine(set.Contains(9));
            //Console.WriteLine(set.Contains(12));
            //Console.WriteLine(set.Contains(3));

            //set.Remove(3);
            //Console.WriteLine(set.Contains(3));

            ////AnalyzeList(17000);
            AnalyzeHashSet(15000);
            AnalyzeSoftuniHashSet(15000);
            //AnalyzeSortedSet(17000);

            //AnalyzeSorting(100000);
            ////AnalyzeSortedSetSorting(100000);
        }

        public static void AnalyzeList(int n)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                list.Add(i);
            }


            for (int i = 0; i < n * 100; i++)
            {
                list.Contains(i);
            }

            Console.WriteLine(watch.ElapsedMilliseconds);
        }

        public static void AnalyzeHashSet(int n)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            HashSet<int> list = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    list.Add(i);
                }
                else
                {
                    list.Add(i * -1);
                }
            }


            for (int i = 0; i < n * 100; i++)
            {
                list.Contains(i);
            }

            Console.WriteLine(watch.ElapsedMilliseconds);
        }

        public static void AnalyzeSoftuniHashSet(int n)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            SoftuniHashSet<int> list = new SoftuniHashSet<int>();
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    list.Add(i);
                }
                else
                {
                    list.Add(i * -1);
                }
            }


            for (int i = 0; i < n * 100; i++)
            {
                list.Contains(i);
            }

            Console.WriteLine(watch.ElapsedMilliseconds);
        }

        public static void AnalyzeSortedSet(int n)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            SortedSet<int> list = new SortedSet<int>();
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    list.Add(i);
                }
                else
                {
                    list.Add(i * -1);
                }
            }


            for (int i = 0; i < n * 100; i++)
            {

                list.Contains(i);
            }

            Console.WriteLine(watch.ElapsedMilliseconds);
        }

        public static void AnalyzeSorting(int n)
        {
            Console.WriteLine("List soring");

            Stopwatch watch = new Stopwatch();
            watch.Start();

            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                list.Add(n);
                list.Sort();
            }

            Console.WriteLine(watch.ElapsedMilliseconds);
        }

        public static void AnalyzeSortedSetSorting(int n)
        {
            Console.WriteLine("Sorted set soring");
            Stopwatch watch = new Stopwatch();
            watch.Start();

            SortedSet<int> list = new SortedSet<int>();
            for (int i = 0; i < n; i++)
            {
                list.Add(n);
            }

            Console.WriteLine(watch.ElapsedMilliseconds);
        }
    }
}
