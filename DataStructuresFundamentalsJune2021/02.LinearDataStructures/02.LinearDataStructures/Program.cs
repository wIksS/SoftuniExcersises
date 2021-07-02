using System;

namespace _02.LinearDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            CoolList<int> list = new CoolList<int>();

            for (int i = 0; i < 100; i++)
            {
                list.Add(i * 5);
                Console.WriteLine($"Internal array count: {list.InternalArrayCount}");
                Console.WriteLine($"List count: {list.Count}");
            }


        }
    }
}
