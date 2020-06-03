using System;
using System.Linq;

namespace ArraysDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };

            int sum = 0;
            foreach (var num in arr)
            {
                sum += num;
            }

            Console.WriteLine(sum);
        }
    }
}
