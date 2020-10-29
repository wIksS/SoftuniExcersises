using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 3, 5, 2,2,2, 1, 8 ,1,1,5,214,33, 2, 2, 2, 1, 8, 1, 1, 5, 214, 33, 2, 2, 2, 1, 8, 1, 1, 5, 214, 33, 2, 2, 2, 1, 8, 1, 1, 5, 214, 33, 2, 2, 2, 1, 8, 1, 1, 5, 214, 33, 2, 2, 2, 1, 8, 1, 1, 5, 214, 33, 2, 2, 2, 1, 8, 1, 1, 5, 214, 33, 2, 2, 2, 1, 8, 1, 1, 5, 214, 33, 2, 2, 2, 1, 8, 1, 1, 5, 214, 33, 2, 2, 2, 1, 8, 1, 1, 5, 214, 33, 2, 2, 2, 1, 8, 1, 1, 5, 214, 33, 2, 2, 2, 1, 8, 1, 1, 5, 214, 33, 2, 2, 2, 1, 8, 1, 1, 5, 214, 33, 2, 2, 2, 1, 8, 1, 1, 5, 214, 33, 2, 2, 2, 1, 8, 1, 1, 5, 214, 33, 2, 2, 2, 1, 8, 1, 1, 5, 214, 33, 2, 2, 2, 1, 8, 1, 1, 5, 214, 33, 2, 2, 2, 1, 8, 1, 1, 5, 214, 33, 2, 2, 2, 1, 8, 1, 1, 5, 214, 33, 2, 2, 2, 1, 8, 1, 1, 5, 214, 33, 2, 2, 2, 1, 8, 1, 1, 5, 214, 33, 2, 2, 2, 1, 8, 1, 1, 5, 214, 33, 2, 2, 2, 1, 8, 1, 1, 5, 214, 33 };
            var arrayList = array.ToList();
            QuickSortImproved(arrayList, 0 , arrayList.Count-1);

            Console.WriteLine(String.Join(",", arrayList));

        }
        static Random rand = new Random();

        public static void QuickSortImproved(List<int> array, int left, int right)
        {
            if (left < right)
            {


                var partitionIndex = Partition(array, left, right);
                QuickSortImproved(array, left, partitionIndex);
                QuickSortImproved(array, partitionIndex + 1, right);
            }
        }

        static int Partition(List<int> array, int left ,int right)
        {
            int pivot = array[(left + right) / 2];
            int i = left - 1;
            int j = right + 1;
            while (true)
            {
                do
                {
                    i++;

                }
                while (array[i] < pivot);
                do
                {
                    j--;

                }
                while (array[j] > pivot);

                if (i >= j)
                {
                    return j;
                }

                var temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

        public static List<int> Quicksort(List<int> array)
        {
            if (array.Count <= 1)
            {
                return array;
            }

            int pivot = array[rand.Next(0, array.Count)];
            List<int> leftArray = new List<int>();
            List<int> rightArray = new List<int>();
            for (int i = 0; i < array.Count; i++)
            {
                if (array[i] < pivot)
                {
                    leftArray.Add(array[i]);
                }
                if (array[i] > pivot)
                {
                    rightArray.Add(array[i]);
                }
            }

            var leftSorted = Quicksort(leftArray);
            var rightSorted = Quicksort(rightArray);
            return leftSorted.Concat(new List<int>() { pivot }).Concat(rightSorted).ToList();
        }

        //static void Quicksort(int[] array, int start , int end)
        //{
        //    int pivot = array[start];
        //    int leftIndex = start;
        //    int rightIndex = end;
        //    for (int i = start; i < end; i++)
        //    {
        //        if (array[i] < pivot)
        //        {
        //            int temp = array[leftIndex];
        //            array[leftIndex] = array[i];
        //            array[i] = temp;
        //            leftIndex++;
        //        }
        //        if (array[i] > pivot)
        //        {
        //            int temp = array[rightIndex];
        //            array[rightIndex] = array[i];
        //            array[i] = temp;
        //            rightIndex--;
        //        }
        //    }

        //    Quicksort(array, start, leftIndex);
        //    Quicksort(array, rightIndex, end);
        //}
    }
}
