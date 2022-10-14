using CustomList;
using System;

namespace ObjectVsGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // no type safety
            GenericList list = new GenericList();
            list.Add(5);
            list.Add("6");
            list.Add("7");
            list.Add(new Program());

            int first = (int) list.Get(0);
            Console.WriteLine(first);


            int second = (int)list.Get(1);
            Console.WriteLine(second);
            return;
            Print("Privet");
            Print(5);
            Print(new Program());
        }

        //static void Print(object obj)
        //{
        //    Console.WriteLine(obj);
        //}

        static void Print<T>(T obj)
        {
            Console.WriteLine(obj);
        }
    }
}
