using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CustomHashsetImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 5000000;
            Stopwatch watch = new Stopwatch();
            watch.Start();
            //List<string> listSet = new List<string>(size);

            //for (int i = 0; i < size; i++)
            //{
            //    listSet.Add($"{i}{i}");
            //}

            //for (int i = 0; i < size; i++)
            //{
            //    listSet.Contains($"{i}{i}");
            //}

            //watch.Stop();
            //Console.WriteLine($"List time -> {watch.Elapsed}");
            //watch.Reset();
            watch.Start();
            CustomHashSet customSet = new CustomHashSet(size);

            for (int i = 0; i < size; i++)
            {
                customSet.Add($"{i}{i}");
            }

            for (int i = 0; i < size; i++)
            {
                customSet.Contains($"{i}{i}");
            }

            watch.Stop();
            Console.WriteLine($"Hashset time -> {watch.Elapsed}");

            watch.Reset();
            watch.Start();
            HashSet<string> normalSet = new HashSet<string>(size);

            for (int i = 0; i < size; i++)
            {
                normalSet.Add($"{i}{i}");
            }

            for (int i = 0; i < size; i++)
            {
                normalSet.Contains($"{i}{i}");
            }

            watch.Stop();
            Console.WriteLine($"Normal set time -> {watch.Elapsed}");
        }
    }
}
