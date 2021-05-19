using System;

namespace _10.MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine($"{n} X {times} = {n * times}");
                times++;
            } while (times <= 10);
            //for (int i = times; i <= 10; i++)
            //{
            //}
        }
    }
}
