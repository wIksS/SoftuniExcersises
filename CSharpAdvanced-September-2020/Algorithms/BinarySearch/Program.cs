using System;

namespace BinarySearch
{
    class Program
    {
        static int count = 0;
        static void Main(string[] args)
        {
            int[] array = new int[1000000]; //{ 1, 2, 3, 4, 5 };
            //{ 1, 2, 5, 7, 8, 9, 15,19, 23, 35, 55, 555, 678, 2333 };
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(BinarySearch(array, number,0, array.Length));
            Console.WriteLine(count);
        }

        private static int BinarySearch(int[] array, int number, int start,
            int end)
        {
            if (start > end)
            {
                return -1;
            }
            count++;
            int middle = (start + end) / 2;

            if (number < array[middle])
            {
                return BinarySearch(array, number, start, middle-1);
            }
            if (number > array[middle])
            {
                return BinarySearch(array, number, middle+1, end);
            }
            else
            {
                return middle;
            }
        }
    }
}
