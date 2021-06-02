using System;
using System.Linq;

namespace _03.AwayFromZeroRounding
{
    class Program
    {
        static void Main(string[] args)
        {
            //0,9 1,5 2,4 2,5 3,14
            double[] array = Console.ReadLine().Split()
                .Select(double.Parse).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    array[i] = 0;
                }
                int roundedNumber = (int) Math.Round(array[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{array[i]} => {roundedNumber}");
            }
        }
    }
}
