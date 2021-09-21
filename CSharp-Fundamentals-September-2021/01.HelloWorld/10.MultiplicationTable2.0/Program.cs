using System;

namespace _10.MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int from = int.Parse(Console.ReadLine());
            int to = 10;

            do
            {
                Console.WriteLine($"{number} X {from} = {number * from}");
                from++;
            } while (from <= to);
        }
    }
}
