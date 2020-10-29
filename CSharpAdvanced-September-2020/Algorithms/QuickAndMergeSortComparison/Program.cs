using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using QuickSort;

namespace QuickAndMergeSortComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1000000;
            Random rand = new Random();
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(0, n);
            }

            Stopwatch timer = new Stopwatch();
            var arrayList = array.ToList();
            timer.Start();
            var sorted = QuickSort.Program.Quicksort(arrayList);
            timer.Stop();
            Console.WriteLine("Quicksort");
            Console.WriteLine(timer.ElapsedMilliseconds);
            timer.Reset();
            var newArrayList = arrayList.ToList();
            timer.Start();
            QuickSort.Program.QuickSortImproved(newArrayList, 0, newArrayList.Count-1);
            timer.Stop();
            Console.WriteLine("Quicksort Improved");
            Console.WriteLine(timer.ElapsedMilliseconds);
            timer.Reset();
            timer.Start();
            var sorted2 = MergeSort.Program.Mergesort(arrayList);
            timer.Stop();
            Console.WriteLine("Mergesort");
            Console.WriteLine(timer.ElapsedMilliseconds);
            timer.Reset();
            timer.Start();
            SelectionSort(arrayList);
            timer.Stop();
            Console.WriteLine("Selection Sort");
            Console.WriteLine(timer.ElapsedMilliseconds);
        }

        static void SelectionSort(List<int> array)
        {
            for (int i = 0; i < array.Count; i++)
            {
                int min = i;
                for (int j = i; j < array.Count; j++)
                {
                    if(array[j] < array[min])
                    {
                        min = j;
                    }
                }

                var temp = array[min];
                array[min] = array[i];
                array[i] = temp;
            }
        }
    }
}
