using System;
using System.Collections.Generic;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<string> stringList = new List<string>();
            var x= stringList[0];
            RandomList list = new RandomList();
            list.Add("1");
            list.Add("2");
            list.Add("3");

            Console.WriteLine(list.RandomString());
        }
    }
}
