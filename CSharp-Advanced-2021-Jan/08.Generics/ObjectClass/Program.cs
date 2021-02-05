using System;
using System.Collections.Generic;

namespace ObjectClass
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> realIntList = new List<int>();
            realIntList.Add(1);
            realIntList.Add(2);

            int result = realIntList[0] + 5;
            // non type safe
            GenericListWithObject intList = new GenericListWithObject();
            intList[0] = "5";
            intList.Add("5");
            intList.Add(6);

            int result2 = (int)intList.GetAt(0) + 5;
            //intList.Add("five");
            //intList.Add(new Program());

            Console.WriteLine(intList[0]);
            Console.WriteLine(intList[1]);

            GenericListWithObject stringList = new GenericListWithObject();

            stringList.Add("five");
            stringList.Add("six");

            Console.WriteLine(stringList.GetAt(0));
            Console.WriteLine(stringList.GetAt(1));
        }
    }
}
