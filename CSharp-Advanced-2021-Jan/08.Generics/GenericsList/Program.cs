using System;
using System.Collections.Generic;

namespace GenericsList
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //GenericList<Func<int>, int> x;
            GenericList<char> charList;
            GenericList<GenericList<char>> charMatrix;
 
            GenericList<string> stringList = new GenericList<string>();

            stringList.Add("one");
            stringList.Add("two");
            stringList.Add("three");

            Console.WriteLine(stringList.GetAt(0));
            Console.WriteLine(stringList.GetAt(1));
            Console.WriteLine(stringList.GetAt(2));

            GenericList<int> list = new GenericList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);

            Console.WriteLine(list.GetAt(0));
            Console.WriteLine(list.GetAt(1));
            Console.WriteLine(list.GetAt(2));
        }
    }
}
