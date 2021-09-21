using System;

namespace _09.MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // 33 * 1 = ..
            //33 * 2= ..
            int number = int.Parse(Console.ReadLine());
            int from = 1;//int.Parse(Console.ReadLine());
            int to = 10;

            for (int i = from; i <= to; i++)
            {
                Console.WriteLine($"{number} X {i} = {number*i}");
            }

        }
    }
}
