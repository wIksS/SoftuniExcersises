using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[] { "adsad","b","b","b","x","o"};

            for (int i = 0; i < array.Length; i++)
            {
                int minIndex = i;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[j][0] < array[minIndex][0])
                    {
                        minIndex = j;
                    }
                }

                string temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }

            Console.WriteLine(String.Join(" ", array));
        }
    }
}
