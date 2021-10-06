using System;

namespace StringJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[5]
            {
                1,2,3,4,5
            };

            Console.WriteLine(string.Join("-------------",nums));
        }
    }
}
