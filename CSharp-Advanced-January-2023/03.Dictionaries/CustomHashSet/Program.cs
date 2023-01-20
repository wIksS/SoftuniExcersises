using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CustomHashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int elementsCount = 100000;
            int containsCount = 100000;
            Stopwatch watch = new Stopwatch();  
            watch.Start();
            MeasureList(elementsCount, containsCount);
            watch.Stop();
            Console.WriteLine($"With List: {watch.ElapsedMilliseconds}");


            watch.Reset();
            watch.Start();
            MeasureSoftuniSet(elementsCount, containsCount);
            watch.Stop();
            Console.WriteLine($"With Softuni Set: {watch.ElapsedMilliseconds}");

            watch.Reset();
            watch.Start();
            MeasureHashSet(elementsCount, containsCount);
            watch.Stop();
            Console.WriteLine($"With HashSet: {watch.ElapsedMilliseconds}");

        }

        private static void MeasureList(int elementsCount, int containsCount)
        {
          
            List<string> list = new List<string>();

            for (int i = 0; i < elementsCount; i++)
            {
                list.Add(i.ToString());
            }

            for (int i = 0; i < containsCount; i++)
            {
                list.Contains(i.ToString());
            }
        }

        private static void MeasureSoftuniSet(int elementsCount, int containsCount)
        {

            SoftuniHashSet list = new SoftuniHashSet();

            for (int i = 0; i < elementsCount; i++)
            {
                list.Add(i.ToString());
            }

            for (int i = 0; i < containsCount; i++)
            {
                list.Contains(i.ToString());
            }
        }

        private static void MeasureHashSet(int elementsCount, int containsCount)
        {

            HashSet<string> list = new HashSet<string>();

            for (int i = 0; i < elementsCount; i++)
            {
                list.Add(i.ToString());
            }

            for (int i = 0; i < containsCount; i++)
            {
                list.Contains(i.ToString());
            }
        }
    }
}
