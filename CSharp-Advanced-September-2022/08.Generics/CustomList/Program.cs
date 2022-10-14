using System;

namespace CustomList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamic list = new GenericList<int>();
            list = new GenericList<int>();
            //list.Add("5");
            //list.Add("hey");
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            int first = list.Get(0);
            Console.WriteLine(first);
            Console.WriteLine(list.Get(1));
            Console.WriteLine(list.Get(2));

            GenericList<string> stringList = new GenericList<string>();

            stringList.Add("Hop");

            string firstElement = stringList.Get(0);

            Console.WriteLine(firstElement);
        }
    }
}
