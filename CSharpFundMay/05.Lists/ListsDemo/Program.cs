using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace ListsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() { "1", "2" };
            //while (true)
            //{
            //    list.AddRange(list);
            //    //Console.WriteLine(String.Join(',', list));
            //    Console.WriteLine(list.Count);
            //    Thread.Sleep(100);
            //}
            list.AddRange(new List<string>() { "1", "2", "1", "2" });
            list.AddRange(new List<string>() { "5", "6", "7", "2" });
            list.AddRange(list);
            Console.WriteLine(String.Join(',', list));

            var firstFiveElements = list.GetRange(0, 5);
            Console.WriteLine("first five");
            Console.WriteLine(String.Join(',', firstFiveElements));


        }
    }
}
