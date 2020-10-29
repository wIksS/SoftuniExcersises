using System;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            SoftUniList<int> list = new SoftUniList<int>();
            list.Add(5);
            list.Add(6);
            list.Add(7);

            Console.WriteLine(list.Get(0));
            Console.WriteLine(list.Get(1));
            Console.WriteLine(list.Get(2));

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
